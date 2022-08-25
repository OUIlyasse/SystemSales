using sysSales.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace sysSales.Notif
{
    public partial class frmNotif : Form
    {
        private enmAction action;
        private int x, y;
        public frmNotif()
        {
            InitializeComponent();
        }
        public enum enmAction { wait, start, close }
        public enum enmType { Success, Warning, Error, Info }

        public void showAlert(string msg, enmType type)
        {
            Opacity = 0;
            StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "Alert" + i.ToString();
                frmNotif fm = (frmNotif)Application.OpenForms[fname];
                if (fm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new System.Drawing.Point(x, y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case enmType.Success:
                    picNotifi.Image = Resources.Accepter_48;
                    BackColor = ColorTranslator.FromHtml("#6EA98D");
                    break;
                case enmType.Warning:
                    picNotifi.Image = Resources.Warning_48;
                    BackColor = ColorTranslator.FromHtml("#FFB355");
                    break;
                case enmType.Error:
                    picNotifi.Image = Resources.Error_48;
                    BackColor = ColorTranslator.FromHtml("#B95D55");
                    break;
                case enmType.Info:
                    picNotifi.Image = Resources.Info_48;
                    BackColor = ColorTranslator.FromHtml("#7D9CEF");
                    break;
            }
            lblMessage.Text = msg;
            Show();
            action = enmAction.start;
            tmNotifi.Interval = 1;
            tmNotifi.Start();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            tmNotifi.Interval = 1;
            action = enmAction.close;
        }

        private void tmNotifi_Tick(object sender, System.EventArgs e)
        {
            switch (action)
            {
                case enmAction.wait:
                    tmNotifi.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    tmNotifi.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    tmNotifi.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}