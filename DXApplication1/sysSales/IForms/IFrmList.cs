using DevExpress.XtraEditors;
using sysSales.Main;
using System;
using static myTools.Tools;

namespace sysSales.IForms
{
    public partial class IFrmList : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private XtraForm form;
        private bool t;
        #endregion Variables
        #region Codes
        public virtual void getData()
        {
        }
        public virtual void OForm(bool t, XtraForm form)
        {
            if (t == true)
            {
                frmMain f = new frmMain();
                OpenForm(f, form, f.mdiManager);
            }
            else
            {
                form.ShowDialog();
            }
        }
        #endregion Codes
        public IFrmList()
        {
            InitializeComponent();
            //getData();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            OForm(t, form);
        }

        private void IFrmList_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}