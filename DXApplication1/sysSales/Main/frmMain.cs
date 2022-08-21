using sysSales.frmList;
using sysSales.Sub;
using static myTools.Tools;

namespace sysSales.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Codes
        private void ShowDate()
        {
            dtDate.EditValue = GetDateTime();
        }
        private void ShowTime()
        {
            timerTimes.Start();
        }
        #endregion Codes
        public frmMain()
        {
            InitializeComponent();
            ShowDate();
            ShowTime();
        }
        public frmMain(string message)
        {
            txtStatus.Caption = message;
        }
        private void btnBranch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmListBranche f = new FrmListBranche();
            OpenForm(this, f, mdiManager);
        }
        private void btnSoftware_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEntreprise_Info f = new frmEntreprise_Info();
            OpenForm(this, f, mdiManager);
        }
        private void timerTimes_Tick(object sender, System.EventArgs e)
        {
            txtTime.Caption = GetDateTime().ToString("T");
        }
    }
}