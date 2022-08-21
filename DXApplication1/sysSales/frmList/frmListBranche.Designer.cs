namespace sysSales.frmList
{
    partial class FrmListBranche
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
            this.gcBranche = new DevExpress.XtraGrid.GridControl();
            this.gvBranche = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcBranche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBranche)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBranche
            // 
            this.gcBranche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBranche.Location = new System.Drawing.Point(12, 88);
            this.gcBranche.MainView = this.gvBranche;
            this.gcBranche.Name = "gcBranche";
            this.gcBranche.Size = new System.Drawing.Size(1240, 550);
            this.gcBranche.TabIndex = 1;
            this.gcBranche.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBranche});
            // 
            // gvBranche
            // 
            this.gvBranche.GridControl = this.gcBranche;
            this.gvBranche.Name = "gvBranche";
            this.gvBranche.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBranche.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBranche.OptionsBehavior.ReadOnly = true;
            this.gvBranche.OptionsFind.AlwaysVisible = true;
            this.gvBranche.OptionsFind.ShowClearButton = false;
            this.gvBranche.OptionsFind.ShowCloseButton = false;
            this.gvBranche.OptionsFind.ShowFindButton = false;
            this.gvBranche.OptionsView.ShowFooter = true;
            // 
            // FrmListBranche
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 650);
            this.Controls.Add(this.gcBranche);
            this.Name = "FrmListBranche";
            this.Text = "frmListBranche";
            this.Controls.SetChildIndex(this.gcBranche, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gcBranche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBranche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBranche;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBranche;
    }
}