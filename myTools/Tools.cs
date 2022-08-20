using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using System;
using System.Windows.Forms;

namespace myTools
{
    public class Tools
    {
        public static DateTime GetDateTime()
        {
            return DateTime.Now;
        }
        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        public static void ILmsgBox(string msg)
        {
            XtraMessageBox.Show(msg);
        }
        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void ILmsgBox(string msg, string title)
        {
            XtraMessageBox.Show(msg, title, MessageBoxButtons.OK);
        }
        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        /// <param name="button">Buttons</param>
        public static void ILmsgBox(string msg, string title, MessageBoxButtons button)
        {
            XtraMessageBox.Show(msg, title, button);
        }
        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        /// <param name="button">Buttons</param>
        /// <param name="icon">Icon</param>
        public static void ILmsgBox(string msg, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            XtraMessageBox.Show(msg, title, button, icon);
        }
        /// <summary>
        /// Open form into XtraTabbedMdiManager
        /// </summary>
        /// <param name="frmMain">Main Form</param>
        /// <param name="formChild">Form Child</param>
        /// <param name="mdiManager">XtraTabbedMdiManager</param>
        public static void OpenForm(RibbonForm frmMain, XtraForm formChild, XtraTabbedMdiManager mdiManager)
        {
            if (!isFormActived(frmMain, formChild, mdiManager))
            {
                formChild.MdiParent = frmMain;

                formChild.WindowState = FormWindowState.Maximized;
                formChild.Show();
            }
        }
        private static bool isFormActived(RibbonForm frmMain, XtraForm formChild, XtraTabbedMdiManager mdiManager)
        {
            bool IsOpenend = false;
            if (frmMain.MdiChildren.Length > 0)
            {
                foreach (var item in frmMain.MdiChildren)
                {
                    if (formChild.Name == item.Name)
                    {
                        mdiManager.Pages[item].MdiChild.Activate();
                        IsOpenend = true;
                    }
                }
            }
            return IsOpenend;
        }
    }
}