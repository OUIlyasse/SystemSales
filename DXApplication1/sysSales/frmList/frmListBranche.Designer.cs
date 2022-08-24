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
            this.barn_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barn_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barn_Nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barn_Mobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barn_Fixe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barn_Date_Creation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barn_Adresse = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcBranche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBranche)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBranche
            // 
            this.gcBranche.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcBranche.Location = new System.Drawing.Point(0, 88);
            this.gcBranche.MainView = this.gvBranche;
            this.gcBranche.Name = "gcBranche";
            this.gcBranche.Size = new System.Drawing.Size(1264, 562);
            this.gcBranche.TabIndex = 1;
            this.gcBranche.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBranche});
            // 
            // gvBranche
            // 
            this.gvBranche.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.barn_ID,
            this.barn_Code,
            this.barn_Nom,
            this.barn_Mobile,
            this.barn_Fixe,
            this.barn_Date_Creation,
            this.barn_Adresse});
            this.gvBranche.GridControl = this.gcBranche;
            this.gvBranche.Name = "gvBranche";
            this.gvBranche.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBranche.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBranche.OptionsBehavior.Editable = false;
            this.gvBranche.OptionsBehavior.ReadOnly = true;
            this.gvBranche.OptionsFind.AlwaysVisible = true;
            this.gvBranche.OptionsFind.ShowClearButton = false;
            this.gvBranche.OptionsFind.ShowCloseButton = false;
            this.gvBranche.OptionsFind.ShowFindButton = false;
            this.gvBranche.OptionsView.ShowFooter = true;
            // 
            // barn_ID
            // 
            this.barn_ID.Caption = "N°";
            this.barn_ID.FieldName = "barn_ID";
            this.barn_ID.Name = "barn_ID";
            // 
            // barn_Code
            // 
            this.barn_Code.Caption = "Code";
            this.barn_Code.FieldName = "barn_Code";
            this.barn_Code.Name = "barn_Code";
            this.barn_Code.Visible = true;
            this.barn_Code.VisibleIndex = 0;
            // 
            // barn_Nom
            // 
            this.barn_Nom.Caption = "Name";
            this.barn_Nom.FieldName = "barn_Nom";
            this.barn_Nom.Name = "barn_Nom";
            this.barn_Nom.Visible = true;
            this.barn_Nom.VisibleIndex = 1;
            // 
            // barn_Mobile
            // 
            this.barn_Mobile.Caption = "Mobile";
            this.barn_Mobile.FieldName = "barn_Mobile";
            this.barn_Mobile.Name = "barn_Mobile";
            this.barn_Mobile.Visible = true;
            this.barn_Mobile.VisibleIndex = 2;
            // 
            // barn_Fixe
            // 
            this.barn_Fixe.Caption = "Fixe";
            this.barn_Fixe.FieldName = "barn_Fixe";
            this.barn_Fixe.Name = "barn_Fixe";
            this.barn_Fixe.Visible = true;
            this.barn_Fixe.VisibleIndex = 3;
            // 
            // barn_Date_Creation
            // 
            this.barn_Date_Creation.Caption = "Creation Date";
            this.barn_Date_Creation.DisplayFormat.FormatString = "D";
            this.barn_Date_Creation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.barn_Date_Creation.FieldName = "barn_Date_Creation";
            this.barn_Date_Creation.Name = "barn_Date_Creation";
            this.barn_Date_Creation.Visible = true;
            this.barn_Date_Creation.VisibleIndex = 4;
            // 
            // barn_Adresse
            // 
            this.barn_Adresse.Caption = "Address";
            this.barn_Adresse.FieldName = "barn_Adresse";
            this.barn_Adresse.Name = "barn_Adresse";
            this.barn_Adresse.Visible = true;
            this.barn_Adresse.VisibleIndex = 5;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gvBranche;
        private DevExpress.XtraGrid.Columns.GridColumn barn_ID;
        private DevExpress.XtraGrid.Columns.GridColumn barn_Code;
        private DevExpress.XtraGrid.Columns.GridColumn barn_Nom;
        private DevExpress.XtraGrid.Columns.GridColumn barn_Mobile;
        private DevExpress.XtraGrid.Columns.GridColumn barn_Fixe;
        private DevExpress.XtraGrid.Columns.GridColumn barn_Date_Creation;
        private DevExpress.XtraGrid.Columns.GridColumn barn_Adresse;
        public DevExpress.XtraGrid.GridControl gcBranche;
    }
}