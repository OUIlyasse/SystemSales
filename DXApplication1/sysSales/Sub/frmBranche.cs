using DevExpress.XtraEditors;
using SalesDB.DB;
using SalesDB.Proc_DB;
using sysSales.frmList;
using sysSales.IForms;
using sysSales.Main;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static myTools.Tools;
using static sysSales.Notif.frmNotif;

namespace sysSales.Sub
{
    public partial class frmBranche : IFrmOut
    {
        #region Variables
        private CRUD<Branche> crd = new CRUD<Branche>();
        private SystemSalesEntities db = new SystemSalesEntities();
        private frmBranche f;
        private FrmListBranche flb;
        private frmMain fm;
        private FrmListBranche frmListBranche;
        #endregion Variables
        #region myCodes
        private void ErrorMessage(TextEdit txt, string msg)
        {
            txt.ErrorText = msg;
            fm.txtStatus.Caption = msg;
            //fm.ribbonStatusBar.BackColor = ColorTranslator.FromHtml("#FFB355");
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
        public override void Data_Add(string msg)
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty)
                    ErrorMessage(txtName, "The name field is empty, please fill it out");
                else if (txtFixe.Text.Trim() == string.Empty)
                    ErrorMessage(txtName, "The fixe field is empty, please fill it out");
                else if (txtAddress.Text.Trim() == string.Empty)
                    ErrorMessage(txtName, "The address field is empty, please fill it out");
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
                        base.Data_Add("Data added successfully");
                    else
                        base.Data_Add("The name field already exists");
                }
            }
            catch (Exception ex) { base.Data_Add(ex.Message); }
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
        public frmBranche(FrmListBranche frm, frmMain fm)
            : base(fm)
        {
            InitializeComponent();
            flb = frm;
            this.fm = fm;
            ClearData();
        }
        public frmBranche(FrmListBranche frmListBranche, frmBranche f)
    : base(f)
        {
            InitializeComponent();
            this.frmListBranche = frmListBranche;
            this.f = f;
            ClearData();
        }
    }
}