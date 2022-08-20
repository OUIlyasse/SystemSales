namespace sysSales.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSoftware = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.txtUsername = new DevExpress.XtraBars.BarStaticItem();
            this.txtStatus = new DevExpress.XtraBars.BarStaticItem();
            this.txtTime = new DevExpress.XtraBars.BarStaticItem();
            this.dtDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPageSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timerTimes = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSoftware,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem4,
            this.txtUsername,
            this.txtStatus,
            this.txtTime,
            this.dtDate});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barSubItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageSettings});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.ribbon.Size = new System.Drawing.Size(1186, 182);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSoftware
            // 
            this.btnSoftware.Caption = "Software";
            this.btnSoftware.Id = 1;
            this.btnSoftware.ImageOptions.Image = global::sysSales.Properties.Resources.software_32;
            this.btnSoftware.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnSoftware.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnSoftware.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftware.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSoftware.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSoftware.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoftware_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Profil";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Login/Logout";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // txtUsername
            // 
            this.txtUsername.Caption = "Username";
            this.txtUsername.Id = 7;
            this.txtUsername.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtUsername.ImageOptions.Image")));
            this.txtUsername.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ItemAppearance.Normal.Options.UseFont = true;
            this.txtUsername.Name = "txtUsername";
            // 
            // txtStatus
            // 
            this.txtStatus.Caption = "msg";
            this.txtStatus.Id = 8;
            this.txtStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.txtStatus.Name = "txtStatus";
            // 
            // txtTime
            // 
            this.txtTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtTime.Caption = "Time";
            this.txtTime.Id = 9;
            this.txtTime.ItemAppearance.Normal.Font = new System.Drawing.Font("Digital-7", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtTime.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.txtTime.ItemAppearance.Normal.Options.UseFont = true;
            this.txtTime.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txtTime.Width = 100;
            // 
            // dtDate
            // 
            this.dtDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.dtDate.AutoHideEdit = false;
            this.dtDate.Edit = this.repositoryItemDateEdit1;
            this.dtDate.EditWidth = 180;
            this.dtDate.Id = 10;
            this.dtDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dtDate.ImageOptions.Image")));
            this.dtDate.Name = "dtDate";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.Appearance.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemDateEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "D";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "D";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "D";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.ReadOnly = true;
            this.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ribbonPageSettings
            // 
            this.ribbonPageSettings.Appearance.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageSettings.Appearance.Options.UseFont = true;
            this.ribbonPageSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageSettings.Name = "ribbonPageSettings";
            this.ribbonPageSettings.Text = "Settings";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSoftware);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtUsername);
            this.ribbonStatusBar.ItemLinks.Add(this.txtStatus, true);
            this.ribbonStatusBar.ItemLinks.Add(this.dtDate);
            this.ribbonStatusBar.ItemLinks.Add(this.txtTime);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 650);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1186, 29);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 182);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 365;
            this.navBarControl1.Size = new System.Drawing.Size(365, 468);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // mdiManager
            // 
            this.mdiManager.Appearance.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiManager.Appearance.Options.UseFont = true;
            this.mdiManager.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(190)))), ((int)(((byte)(221)))));
            this.mdiManager.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiManager.AppearancePage.HeaderActive.Options.UseBorderColor = true;
            this.mdiManager.AppearancePage.HeaderActive.Options.UseFont = true;
            this.mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.mdiManager.MdiParent = this;
            // 
            // timerTimes
            // 
            this.timerTimes.Interval = 1000;
            this.timerTimes.Tick += new System.EventHandler(this.timerTimes_Tick);
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 679);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sales System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnSoftware;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarStaticItem txtUsername;
        private DevExpress.XtraBars.BarStaticItem txtTime;
        private DevExpress.XtraBars.BarEditItem dtDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private System.Windows.Forms.Timer timerTimes;
        public DevExpress.XtraBars.BarStaticItem txtStatus;
        public DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    }
}