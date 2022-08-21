using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using SalesDB.DB;
using SalesDB.Proc_DB;
using sysSales.IForms;
using System;
using System.Linq;
using static myTools.Tools;

namespace sysSales.Sub
{
    public partial class frmBranche : IFrm
    {
        #region Variables
        private Branche bran;
        private CRUD<Branche> crd = new CRUD<Branche>();
        private SystemSalesEntities db = new SystemSalesEntities();
        #endregion Variables
        #region myCodes
        public void ClearData()
        {
            txtCode.Text = getCode();
            txtName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtFixe.Text = string.Empty;
            dtCreateDate.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNote.Text = string.Empty;
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
            ClearData();
            base.Data_Add();
        }
        #endregion Override
        public frmBranche()
        {
            InitializeComponent();
            ClearData();
        }
    }
}