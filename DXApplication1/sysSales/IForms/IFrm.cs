using sysSales.Main;
using sysSales.Notif;
using System;
using System.Windows.Forms;
using static myTools.Tools;
using static sysSales.Notif.frmNotif;

namespace sysSales.IForms
{
    public partial class IFrm : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private frmMain fm;
        #endregion Variables
        #region myCodes
        public virtual void ClearData()
        {
        }
        public virtual void Data_Add(string msg)
        {
            if (msg == "Data added successfully")
            {
                fm.txtStatus.Caption = msg;
                Notification(msg, enmType.Success);
                ClearData();
            }
            else
            {
                //ILmsgBox(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Notification(msg, enmType.Error);
            }
        }
        public virtual void Notification(string msg, enmType type)
        {
            frmNotif fm = new frmNotif();
            fm.showAlert(msg, type);
        }
        #endregion myCodes
        public IFrm(frmMain form)
        {
            InitializeComponent();
            fm = form;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data_Add("");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}