using SalesDB.DB;
using SalesDB.Proc_DB;
using sysSales.frmList;
using sysSales.IForms;
using System;
using System.Linq;
using System.Windows.Forms;
using static myTools.Tools;

namespace sysSales.Sub
{
    public partial class frmBranche : IFrmOut
    {
        #region Variables
        private Branche brn;
        private CRUD<Branche> crd = new CRUD<Branche>();
        private SystemSalesEntities db = new SystemSalesEntities();
        private FrmListBranche flb;
        #endregion Variables
        #region myCodes
        public override void ClearData()
        {
            txtCode.Text = getCode();
            txtName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtFixe.Text = string.Empty;
            dtCreateDate.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtName.Focus();
        }
        private string getCode()
        {
            return string.Format("BRN{0:0000}{1}{2}", Convert.ToDecimal(getMaxID()), GetDateTime().ToString("dd"), GetDateTime().ToString("MM"));
        }
        private string getMaxID()
        {
            var max = db.Branches.Any() ? db.Branches.Max(x => x.barn_ID) + 1 : 1;
            return max.ToString();
        }

        #endregion myCodes

        #region Override
        public override void Data_Add()
        {
            try
            {
                if (vp.Validate())
                {
                    brn = new Branche();
                    brn.barn_ID = Convert.ToDecimal(getMaxID());
                    brn.barn_Code = getCode();
                    brn.barn_Nom = txtName.Text;
                    brn.barn_Mobile = txtMobile.Text;
                    brn.barn_Fixe = txtFixe.Text;
                    brn.barn_Adresse = txtAddress.Text;
                    brn.barn_Date_Creation = dtCreateDate.DateTime;
                    brn.barn_Status = 1;
                    brn.barn_Note = txtNote.Text;
                    brn.entr_ID = 1;
                    if (crd.Add(brn))
                    {
                        base.Data_Add();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                ILmsgBox(ex.InnerException.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public override void Data_Delete()
        {
            base.Data_Delete();
        }
        public override void Data_Update()
        {
            try
            {
                if (vp.Validate())
                {
                }
            }
            catch (Exception ex)
            {
                ILmsgBox(ex.InnerException.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            base.Data_Update();
        }
        public override void getData()
        {
            flb.gcBranche.DataSource = db.Select_Branche();
        }
        #endregion Override
        public frmBranche(FrmListBranche frm)
        {
            InitializeComponent();
            flb = frm;
            ClearData();
        }
    }
}