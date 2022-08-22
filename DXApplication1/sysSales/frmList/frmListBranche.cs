using DevExpress.XtraEditors;
using SalesDB.DB;
using sysSales.IForms;
using sysSales.Sub;
using System.Windows.Forms;
using static myTools.Tools;

namespace sysSales.frmList
{
    public partial class FrmListBranche : IFrmList
    {
        #region Variables
        private Branche brn;
        //private CRUD<Entreprise_Info> crd = new CRUD<Entreprise_Info>();
        private SystemSalesEntities db = new SystemSalesEntities();
        private frmBranche f = new frmBranche();
        #endregion Variables
        #region Override
        public override void getData()
        {
            try
            {
                gcBranche.DataSource = db.Select_Branche();
                base.getData();
            }
            catch (System.Exception ex)
            {
                ILmsgBox(ex.InnerException.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void showForm(XtraForm form)
        {
            base.showForm(f);
        }
        #endregion Override
        public FrmListBranche()
        {
            InitializeComponent();
        }
        public FrmListBranche(bool t, XtraForm form)
            : base(t, form)
        {
            InitializeComponent();
        }
    }
}