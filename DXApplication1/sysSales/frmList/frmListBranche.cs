using DevExpress.XtraEditors;
using SalesDB.DB;
using sysSales.IForms;
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
        public override void OForm(bool t, XtraForm form)
        {
            base.OForm(t, form);
        }
        #endregion Override
        public FrmListBranche()
        {
            InitializeComponent();
        }
    }
}