namespace sysSales.Notif
{
    partial class frmNotif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tmNotifi = new System.Windows.Forms.Timer(this.components);
            this.picNotifi = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picNotifi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(80, 57);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(96, 23);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // tmNotifi
            // 
            this.tmNotifi.Tick += new System.EventHandler(this.tmNotifi_Tick);
            // 
            // picNotifi
            // 
            this.picNotifi.Image = global::sysSales.Properties.Resources.Accepter_48;
            this.picNotifi.Location = new System.Drawing.Point(12, 44);
            this.picNotifi.Name = "picNotifi";
            this.picNotifi.Size = new System.Drawing.Size(48, 48);
            this.picNotifi.TabIndex = 2;
            this.picNotifi.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::sysSales.Properties.Resources.Cancel_32;
            this.btnClose.Location = new System.Drawing.Point(491, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNotif
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(525, 136);
            this.Controls.Add(this.picNotifi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotif";
            this.Text = "frmNotif";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picNotifi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picNotifi;
        private System.Windows.Forms.Timer tmNotifi;
    }
}