using DevExpress.XtraEditors;
using System;

namespace sysSales.IForms
{
    public partial class IFrmList : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private XtraForm form;
        #endregion Variables
        #region Codes
        public virtual void getData()
        {
        }
        public virtual void showForm(XtraForm form)
        {
            form.ShowDialog();
        }
        #endregion Codes
        public IFrmList()
        {
            InitializeComponent();
            //getData();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            showForm(form);
        }

        private void IFrmList_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}