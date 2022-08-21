using System;
using System.Windows.Forms;
using static myTools.Tools;

namespace sysSales.IForms
{
    public partial class IFrmOut : DevExpress.XtraEditors.XtraForm
    {
        #region myCodes
        public virtual void Data_Add()
        {
            ILmsgBox("Data added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public virtual void Data_Delete()
        {
            ILmsgBox("Data deleted successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public virtual void Data_Update()
        {
            ILmsgBox("Data updated successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion myCodes
        public IFrmOut()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data_Add();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Data_Delete();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Data_Update();
        }
    }
}