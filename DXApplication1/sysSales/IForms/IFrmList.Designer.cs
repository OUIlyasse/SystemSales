namespace sysSales.IForms
{
    partial class IFrmList
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
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnNew.Appearance.Options.UseBackColor = true;
            this.btnNew.AutoSize = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.ImageOptions.Image = global::sysSales.Properties.Resources.New_File_64;
            this.btnNew.Location = new System.Drawing.Point(1180, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 70);
            this.btnNew.TabIndex = 0;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // IFrmList
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 650);
            this.Controls.Add(this.btnNew);
            this.Name = "IFrmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IFrmList";
            this.Load += new System.EventHandler(this.IFrmList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNew;
    }
}