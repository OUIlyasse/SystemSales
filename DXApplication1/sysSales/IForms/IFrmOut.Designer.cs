namespace sysSales.IForms
{
    partial class IFrmOut
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
            this.gcControls = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcControls)).BeginInit();
            this.gcControls.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcControls
            // 
            this.gcControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcControls.Controls.Add(this.btnDelete);
            this.gcControls.Controls.Add(this.btnUpdate);
            this.gcControls.Controls.Add(this.btnAdd);
            this.gcControls.Location = new System.Drawing.Point(211, 15);
            this.gcControls.Name = "gcControls";
            this.gcControls.ShowCaption = false;
            this.gcControls.Size = new System.Drawing.Size(461, 89);
            this.gcControls.TabIndex = 0;
            this.gcControls.Text = "groupControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.AutoSize = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ImageOptions.Image = global::sysSales.Properties.Resources.Recycle_Bin_Full_64;
            this.btnDelete.Location = new System.Drawing.Point(314, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 70);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.ToolTip = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ImageOptions.Image = global::sysSales.Properties.Resources.Edit_64;
            this.btnUpdate.Location = new System.Drawing.Point(177, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 70);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.ToolTip = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.AutoSize = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ImageOptions.Image = global::sysSales.Properties.Resources.Plus_64;
            this.btnAdd.Location = new System.Drawing.Point(40, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 70);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.ToolTip = "Add";
            this.btnAdd.ToolTipController = this.toolTipController1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.gcControls);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(0, 435);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(882, 118);
            this.pnlControls.TabIndex = 2;
            // 
            // IFrmOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pnlControls);
            this.Name = "IFrmOut";
            this.Text = "IFrmOut";
            ((System.ComponentModel.ISupportInitialize)(this.gcControls)).EndInit();
            this.gcControls.ResumeLayout(false);
            this.gcControls.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcControls;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel pnlControls;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}