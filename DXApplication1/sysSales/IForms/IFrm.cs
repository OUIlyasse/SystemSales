using System;
using System.Windows.Forms;
using static myTools.Tools;

namespace sysSales.IForms
{
    public partial class IFrm : DevExpress.XtraEditors.XtraForm
    {
        #region myCodes
        public virtual void ClearData()
        {
        }
        public virtual void Data_Add()
        {
            ILmsgBox("Data added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }
        #endregion myCodes
        public IFrm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data_Add();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}