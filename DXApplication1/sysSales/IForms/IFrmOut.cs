using sysSales.Main;
using sysSales.Notif;
using sysSales.Sub;
using System;
using System.Drawing;
using System.Windows.Forms;
using static myTools.Tools;
using static sysSales.Notif.frmNotif;

namespace sysSales.IForms
{
    public partial class IFrmOut : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private frmBranche fBranche;
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
                getData();
            }
            else
            {
                //fm.txtStatus.Caption = msg;
                Notification(msg, enmType.Error);
            }
        }
        public virtual void Data_Delete()
        {
            ILmsgBox("Data deleted successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            getData();
        }
        public virtual void Data_Update()
        {
            ILmsgBox("Data updated successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            getData();
        }
        public virtual void getData()
        {
        }
        public virtual void Notification(string msg, enmType type)
        {
            frmNotif f = new frmNotif();
            f.showAlert(msg, type);
        }
        #endregion myCodes
        public IFrmOut(frmMain form)
        {
            InitializeComponent();
            fm = form;
        }
        public IFrmOut(frmBranche form)
        {
            InitializeComponent();
            fBranche = form;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data_Add("");
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