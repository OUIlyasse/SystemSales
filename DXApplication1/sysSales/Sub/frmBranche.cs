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
        public override void Data_Add()
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty)
                    txtName.ErrorText = "The name field is empty, please fill it out";
                else if (txtFixe.Text.Trim() == string.Empty)
                    txtFixe.ErrorText = "The fixe field is empty, please fill it out";
                else if (txtAddress.Text.Trim() == string.Empty)
                    txtAddress.ErrorText = "The address field is empty, please fill it out";
                else
                {
                    var ID = Convert.ToDecimal(getMaxID());
                    var Code = getCode();
                    var Nom = txtName.Text;
                    var Mobile = txtMobile.Text;
                    var Fixe = txtFixe.Text;
                    var Adresse = txtAddress.Text;
                    var Date_Creation = dtCreateDate.DateTime;
                    var Status = 1;
                    var Note = txtNote.Text;
                    var entr_ID = 1;
                    if (db.Insert_Branche(ID, Code, Nom, Mobile, Fixe, Adresse, Date_Creation, Status, Note, entr_ID) > 0)
                        base.Data_Add();
                    else
                        ILmsgBox("The name field already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //db.Insert_Branche(ID, Code, Nom, Mobile, Fixe, Adresse, Date_Creation, Status, Note, entr_ID);
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