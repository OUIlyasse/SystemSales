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
        }
        public IFrmList(bool t, XtraForm form)
        {
            InitializeComponent();
            this.t = t;
            this.form = form;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OForm(t, form);
        }
    }
}