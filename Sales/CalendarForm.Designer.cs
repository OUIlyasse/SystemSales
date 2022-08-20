using Syncfusion.Schedule;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using System;
namespace Sales
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.infobackStageTab = new Syncfusion.Windows.Forms.BackStageTab();
            this.homeTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.newtoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.newAppointmenttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newMeetingToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newItemstoolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goTotoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.todayToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nextDaystoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.communicatetoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.dayToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.workWeekToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.weektoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.monthtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.scheduleViewtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sendreceiveTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.sendreceivetoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.sendreceivetoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.sendreceivetoolStripPanelItem = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.UpdateFolderButton = new System.Windows.Forms.ToolStripButton();
            this.SendAllButton = new System.Windows.Forms.ToolStripButton();
            this.SendReceiveGroupsSplit = new System.Windows.Forms.ToolStripSplitButton();
            this.downloadtoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.showProgresstoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.cancelAlltoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.servertoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.downloadHeadersButton = new System.Windows.Forms.ToolStripButton();
            this.serverPanelItem = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.markToDownloadSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.unmarkToDownloadSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.processHeadersSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.preferencesToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.downloadpreferencesButton = new System.Windows.Forms.ToolStripButton();
            this.workOfflineButton = new System.Windows.Forms.ToolStripButton();
            this.folderTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.newfoldertoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.newFoldertoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newSearchtoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.actiontoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.renamefoldertoolstripButton = new System.Windows.Forms.ToolStripButton();
            this.actionPanelItem = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.copyFolderButton = new System.Windows.Forms.ToolStripButton();
            this.moveFolderButton = new System.Windows.Forms.ToolStripButton();
            this.deleteFolderButton = new System.Windows.Forms.ToolStripButton();
            this.cleanuptoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.markAllAsReadButton = new System.Windows.Forms.ToolStripButton();
            this.runRulesNowButton = new System.Windows.Forms.ToolStripButton();
            this.showAllButton = new System.Windows.Forms.ToolStripButton();
            this.cleanUpPanelItem = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.cleanUpFolderDropDowmButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.deleteAllButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.recoverDeletedItemSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.favoritestoolStrip = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.showInFavouritesDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.onlineviewtoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.viewOnServerDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.propertiestoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.autoArchieveButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.folderPermissionDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.folderPropertiesButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.currentViewtoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.changeViewSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewSettingDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.resetViewButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.messagestoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.messagesPanelItem = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.showAsConvesationCheckBox = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.conversationSettingSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.layouttoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.folderPaneSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.readingPaneSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toDoBarSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.peoplePanetoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.peoplePaneSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.windowtoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.remainderWindowButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openInNewWIndowButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeAllItemsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.combotoolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.tabsimageList = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).BeginInit();
            this.backStage1.SuspendLayout();
            this.homeTabItem.Panel.SuspendLayout();
            this.newtoolStripEx.SuspendLayout();
            this.goTotoolStripEx.SuspendLayout();
            this.communicatetoolStripEx.SuspendLayout();
            this.sendreceiveTabItem.Panel.SuspendLayout();
            this.sendreceivetoolStripEx.SuspendLayout();
            this.downloadtoolStripEx.SuspendLayout();
            this.servertoolStripEx.SuspendLayout();
            this.preferencesToolStripEx.SuspendLayout();
            this.folderTabItem.Panel.SuspendLayout();
            this.newfoldertoolStripEx.SuspendLayout();
            this.actiontoolStripEx.SuspendLayout();
            this.cleanuptoolStripEx.SuspendLayout();
            this.favoritestoolStrip.SuspendLayout();
            this.onlineviewtoolStripEx.SuspendLayout();
            this.propertiestoolStripEx.SuspendLayout();
            this.viewTabItem.Panel.SuspendLayout();
            this.currentViewtoolStripEx.SuspendLayout();
            this.messagestoolStripEx.SuspendLayout();
            this.layouttoolStripEx.SuspendLayout();
            this.peoplePanetoolStripEx.SuspendLayout();
            this.windowtoolStripEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(homeTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(sendreceiveTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(folderTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(viewTabItem);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.QuickPanelVisible = false;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.homeTabItem;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1352, 192);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
            this.ribbonControlAdv1.TitleColor = System.Drawing.Color.Black;
            this.ribbonControlAdv1.TouchMode = true;
            // 
            // backStageView1
            // 
            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;
            // 
            // backStage1
            // 
            this.backStage1.AllowDrop = true;
            this.backStage1.BackStagePanelWidth = 160;
            this.backStage1.BeforeTouchSize = new System.Drawing.Size(1348, 521);
            this.backStage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backStage1.ChildItemSize = new System.Drawing.Size(80, 140);
            this.backStage1.Controls.Add(this.infobackStageTab);
            this.backStage1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.backStage1.ItemSize = new System.Drawing.Size(160, 40);
            this.backStage1.Location = new System.Drawing.Point(0, 0);
            this.backStage1.MinimumSize = new System.Drawing.Size(100, 65);
            this.backStage1.Name = "backStage1";
            this.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            this.backStage1.Size = new System.Drawing.Size(1348, 521);
            this.backStage1.TabIndex = 4;
            this.backStage1.ThemeName = "BackStageRenderer";
            this.backStage1.Visible = false;
            // 
            // infobackStageTab
            // 
            this.infobackStageTab.Accelerator = "";
            this.infobackStageTab.BackColor = System.Drawing.Color.White;
            this.infobackStageTab.Image = null;
            this.infobackStageTab.ImageSize = new System.Drawing.Size(16, 16);
            this.infobackStageTab.Location = new System.Drawing.Point(159, 0);
            this.infobackStageTab.Name = "infobackStageTab";
            this.infobackStageTab.Placement = Syncfusion.Windows.Forms.BackStageItemPlacement.Top;
            this.infobackStageTab.Position = new System.Drawing.Point(11, 55);
            this.infobackStageTab.ShowCloseButton = true;
            this.infobackStageTab.Size = new System.Drawing.Size(1189, 521);
            this.infobackStageTab.TabIndex = 3;
            this.infobackStageTab.Text = "Info";
            this.infobackStageTab.ThemesEnabled = false;
            // 
            // homeTabItem
            // 
            this.homeTabItem.Name = "homeTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.homeTabItem.Panel.Controls.Add(this.newtoolStripEx);
            this.homeTabItem.Panel.Controls.Add(this.goTotoolStripEx);
            this.homeTabItem.Panel.Controls.Add(this.communicatetoolStripEx);
            this.homeTabItem.Panel.Name = "ribbonPanel1";
            this.homeTabItem.Panel.ScrollPosition = 0;
            this.homeTabItem.Panel.TabIndex = 2;
            this.homeTabItem.Panel.Text = "Home";
            this.homeTabItem.Position = 0;
            this.homeTabItem.Size = new System.Drawing.Size(66, 41);
            this.homeTabItem.Tag = "1";
            this.homeTabItem.Text = "Home";
            // 
            // newtoolStripEx
            // 
            this.newtoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.newtoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.newtoolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.newtoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.newtoolStripEx.Image = null;
            this.newtoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.newtoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAppointmenttoolStripButton,
            this.newMeetingToolStripButton,
            this.newItemstoolStripDropDownButton});
            this.newtoolStripEx.Location = new System.Drawing.Point(0, 1);
            this.newtoolStripEx.Name = "newtoolStripEx";
            this.newtoolStripEx.Office12Mode = false;
            this.newtoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.newtoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newtoolStripEx.Size = new System.Drawing.Size(234, 104);
            this.newtoolStripEx.TabIndex = 0;
            this.newtoolStripEx.Text = "New";
            // 
            // newAppointmenttoolStripButton
            // 
            this.newAppointmenttoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newAppointmenttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newAppointmenttoolStripButton.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.newAppointmenttoolStripButton.Name = "newAppointmenttoolStripButton";
            this.newAppointmenttoolStripButton.Size = new System.Drawing.Size(94, 82);
            this.newAppointmenttoolStripButton.Text = "New \r\nAppointment";
            this.newAppointmenttoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // newMeetingToolStripButton
            // 
            this.newMeetingToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newMeetingToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMeetingToolStripButton.Name = "newMeetingToolStripButton";
            this.newMeetingToolStripButton.Size = new System.Drawing.Size(64, 82);
            this.newMeetingToolStripButton.Text = "New \r\nMeeting";
            this.newMeetingToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // newItemstoolStripDropDownButton
            // 
            this.newItemstoolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.meetingToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.tAskToolStripMenuItem});
            this.newItemstoolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newItemstoolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newItemstoolStripDropDownButton.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.newItemstoolStripDropDownButton.Name = "newItemstoolStripDropDownButton";
            this.newItemstoolStripDropDownButton.Size = new System.Drawing.Size(57, 82);
            this.newItemstoolStripDropDownButton.Text = "New\r\nItems";
            this.newItemstoolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // meetingToolStripMenuItem
            // 
            this.meetingToolStripMenuItem.Name = "meetingToolStripMenuItem";
            this.meetingToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.meetingToolStripMenuItem.Text = "Meeting";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // tAskToolStripMenuItem
            // 
            this.tAskToolStripMenuItem.Name = "tAskToolStripMenuItem";
            this.tAskToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.tAskToolStripMenuItem.Text = "Task";
            // 
            // goTotoolStripEx
            // 
            this.goTotoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.goTotoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.goTotoolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.goTotoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.goTotoolStripEx.Image = null;
            this.goTotoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.goTotoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todayToolStripButton,
            this.nextDaystoolStripButton});
            this.goTotoolStripEx.Location = new System.Drawing.Point(236, 1);
            this.goTotoolStripEx.Name = "goTotoolStripEx";
            this.goTotoolStripEx.Office12Mode = false;
            this.goTotoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.goTotoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goTotoolStripEx.Size = new System.Drawing.Size(118, 104);
            this.goTotoolStripEx.TabIndex = 1;
            this.goTotoolStripEx.Text = "Go To";
            // 
            // todayToolStripButton
            // 
            this.todayToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.todayToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.todayToolStripButton.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.todayToolStripButton.Name = "todayToolStripButton";
            this.todayToolStripButton.Size = new System.Drawing.Size(49, 82);
            this.todayToolStripButton.Text = "Today\r\n";
            this.todayToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // nextDaystoolStripButton
            // 
            this.nextDaystoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nextDaystoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextDaystoolStripButton.Name = "nextDaystoolStripButton";
            this.nextDaystoolStripButton.Size = new System.Drawing.Size(53, 82);
            this.nextDaystoolStripButton.Text = "Next 7\r\nDays";
            this.nextDaystoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // communicatetoolStripEx
            // 
            this.communicatetoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.communicatetoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.communicatetoolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.communicatetoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.communicatetoolStripEx.Image = null;
            this.communicatetoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.communicatetoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripButton,
            this.workWeekToolStripButton,
            this.weektoolStripButton,
            this.monthtoolStripButton,
            this.scheduleViewtoolStripButton});
            this.communicatetoolStripEx.Location = new System.Drawing.Point(356, 1);
            this.communicatetoolStripEx.Name = "communicatetoolStripEx";
            this.communicatetoolStripEx.Office12Mode = false;
            this.communicatetoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.communicatetoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.communicatetoolStripEx.Size = new System.Drawing.Size(267, 104);
            this.communicatetoolStripEx.TabIndex = 2;
            this.communicatetoolStripEx.Text = " Communicate";
            // 
            // dayToolStripButton
            // 
            this.dayToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dayToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dayToolStripButton.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.dayToolStripButton.Name = "dayToolStripButton";
            this.dayToolStripButton.Size = new System.Drawing.Size(37, 82);
            this.dayToolStripButton.Text = "Day\r\n";
            this.dayToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // workWeekToolStripButton
            // 
            this.workWeekToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.workWeekToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.workWeekToolStripButton.Name = "workWeekToolStripButton";
            this.workWeekToolStripButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.workWeekToolStripButton.Size = new System.Drawing.Size(46, 82);
            this.workWeekToolStripButton.Text = "Work\r\nWeek";
            this.workWeekToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // weektoolStripButton
            // 
            this.weektoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.weektoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.weektoolStripButton.Name = "weektoolStripButton";
            this.weektoolStripButton.Size = new System.Drawing.Size(46, 82);
            this.weektoolStripButton.Text = "Week\r\n";
            this.weektoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // monthtoolStripButton
            // 
            this.monthtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.monthtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.monthtoolStripButton.Name = "monthtoolStripButton";
            this.monthtoolStripButton.Size = new System.Drawing.Size(55, 82);
            this.monthtoolStripButton.Text = "Month\r\n";
            this.monthtoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // scheduleViewtoolStripButton
            // 
            this.scheduleViewtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleViewtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scheduleViewtoolStripButton.Name = "scheduleViewtoolStripButton";
            this.scheduleViewtoolStripButton.Size = new System.Drawing.Size(67, 82);
            this.scheduleViewtoolStripButton.Text = "Schedule\r\nView";
            this.scheduleViewtoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sendreceiveTabItem
            // 
            this.sendreceiveTabItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendreceiveTabItem.Name = "sendreceiveTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.sendreceiveTabItem.Panel.Controls.Add(this.sendreceivetoolStripEx);
            this.sendreceiveTabItem.Panel.Controls.Add(this.downloadtoolStripEx);
            this.sendreceiveTabItem.Panel.Controls.Add(this.servertoolStripEx);
            this.sendreceiveTabItem.Panel.Controls.Add(this.preferencesToolStripEx);
            this.sendreceiveTabItem.Panel.Name = "ribbonPanel2";
            this.sendreceiveTabItem.Panel.ScrollPosition = 0;
            this.sendreceiveTabItem.Panel.TabIndex = 3;
            this.sendreceiveTabItem.Panel.Text = "Send/Receive";
            this.sendreceiveTabItem.Position = 1;
            this.sendreceiveTabItem.Size = new System.Drawing.Size(109, 41);
            this.sendreceiveTabItem.Tag = "2";
            this.sendreceiveTabItem.Text = "Send/Receive";
            // 
            // sendreceivetoolStripEx
            // 
            this.sendreceivetoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.sendreceivetoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.sendreceivetoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sendreceivetoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sendreceivetoolStripEx.Image = null;
            this.sendreceivetoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sendreceivetoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendreceivetoolStripButton,
            this.sendreceivetoolStripPanelItem});
            this.sendreceivetoolStripEx.Location = new System.Drawing.Point(0, 1);
            this.sendreceivetoolStripEx.Name = "sendreceivetoolStripEx";
            this.sendreceivetoolStripEx.Office12Mode = false;
            this.sendreceivetoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.sendreceivetoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sendreceivetoolStripEx.Size = new System.Drawing.Size(280, 121);
            this.sendreceivetoolStripEx.TabIndex = 0;
            this.sendreceivetoolStripEx.Text = "Send and Receive";
            // 
            // sendreceivetoolStripButton
            // 
            this.sendreceivetoolStripButton.ForeColor = System.Drawing.Color.Black;
            this.sendreceivetoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendreceivetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendreceivetoolStripButton.Name = "sendreceivetoolStripButton";
            this.sendreceivetoolStripButton.Size = new System.Drawing.Size(107, 99);
            this.sendreceivetoolStripButton.Text = "Send/Receive \r\nAll Folders";
            this.sendreceivetoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sendreceivetoolStripPanelItem
            // 
            this.sendreceivetoolStripPanelItem.CausesValidation = false;
            this.sendreceivetoolStripPanelItem.ForeColor = System.Drawing.Color.Black;
            this.sendreceivetoolStripPanelItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateFolderButton,
            this.SendAllButton,
            this.SendReceiveGroupsSplit});
            this.sendreceivetoolStripPanelItem.Name = "sendreceivetoolStripPanelItem";
            this.sendreceivetoolStripPanelItem.Padding = new System.Windows.Forms.Padding(0);
            this.sendreceivetoolStripPanelItem.Size = new System.Drawing.Size(165, 102);
            this.sendreceivetoolStripPanelItem.Text = "toolStripPanelItem1";
            this.sendreceivetoolStripPanelItem.Transparent = true;
            // 
            // UpdateFolderButton
            // 
            this.UpdateFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateFolderButton.Name = "UpdateFolderButton";
            this.UpdateFolderButton.Size = new System.Drawing.Size(130, 28);
            this.UpdateFolderButton.Text = "Update Folder";
            // 
            // SendAllButton
            // 
            this.SendAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendAllButton.Name = "SendAllButton";
            this.SendAllButton.Size = new System.Drawing.Size(90, 28);
            this.SendAllButton.Text = "Send All";
            // 
            // SendReceiveGroupsSplit
            // 
            this.SendReceiveGroupsSplit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SendReceiveGroupsSplit.Name = "SendReceiveGroupsSplit";
            this.SendReceiveGroupsSplit.Size = new System.Drawing.Size(165, 24);
            this.SendReceiveGroupsSplit.Text = "Send/ReceiveGroups";
            // 
            // downloadtoolStripEx
            // 
            this.downloadtoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.downloadtoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.downloadtoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.downloadtoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.downloadtoolStripEx.Image = null;
            this.downloadtoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.downloadtoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProgresstoolStripButton,
            this.cancelAlltoolStripButton});
            this.downloadtoolStripEx.Location = new System.Drawing.Point(52, 1);
            this.downloadtoolStripEx.Name = "downloadtoolStripEx";
            this.downloadtoolStripEx.Office12Mode = false;
            this.downloadtoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.downloadtoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.downloadtoolStripEx.Size = new System.Drawing.Size(145, 121);
            this.downloadtoolStripEx.TabIndex = 1;
            this.downloadtoolStripEx.Text = "Download";
            // 
            // showProgresstoolStripButton
            // 
            this.showProgresstoolStripButton.ForeColor = System.Drawing.Color.Black;
            this.showProgresstoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showProgresstoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showProgresstoolStripButton.Name = "showProgresstoolStripButton";
            this.showProgresstoolStripButton.Size = new System.Drawing.Size(76, 99);
            this.showProgresstoolStripButton.Text = "Show \r\nProgress";
            this.showProgresstoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cancelAlltoolStripButton
            // 
            this.cancelAlltoolStripButton.ForeColor = System.Drawing.Color.Black;
            this.cancelAlltoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelAlltoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelAlltoolStripButton.Name = "cancelAlltoolStripButton";
            this.cancelAlltoolStripButton.Size = new System.Drawing.Size(63, 99);
            this.cancelAlltoolStripButton.Text = "Cancel\r\nAll";
            this.cancelAlltoolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelAlltoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // servertoolStripEx
            // 
            this.servertoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.servertoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.servertoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.servertoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.servertoolStripEx.Image = null;
            this.servertoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.servertoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadHeadersButton,
            this.serverPanelItem});
            this.servertoolStripEx.Location = new System.Drawing.Point(429, 1);
            this.servertoolStripEx.Name = "servertoolStripEx";
            this.servertoolStripEx.Office12Mode = false;
            this.servertoolStripEx.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.servertoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.servertoolStripEx.Size = new System.Drawing.Size(320, 121);
            this.servertoolStripEx.TabIndex = 2;
            this.servertoolStripEx.Text = "Server";
            this.servertoolStripEx.Visible = false;
            // 
            // downloadHeadersButton
            // 
            this.downloadHeadersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downloadHeadersButton.Name = "downloadHeadersButton";
            this.downloadHeadersButton.Size = new System.Drawing.Size(79, 113);
            this.downloadHeadersButton.Text = "Download \r\nHeaders";
            this.downloadHeadersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // serverPanelItem
            // 
            this.serverPanelItem.CausesValidation = false;
            this.serverPanelItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.serverPanelItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markToDownloadSplitButton,
            this.unmarkToDownloadSplitButton,
            this.processHeadersSplitButton});
            this.serverPanelItem.Name = "serverPanelItem";
            this.serverPanelItem.Size = new System.Drawing.Size(194, 116);
            this.serverPanelItem.Text = "toolStripPanelItem1";
            this.serverPanelItem.Transparent = true;
            // 
            // markToDownloadSplitButton
            // 
            this.markToDownloadSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.markToDownloadSplitButton.Name = "markToDownloadSplitButton";
            this.markToDownloadSplitButton.Size = new System.Drawing.Size(152, 24);
            this.markToDownloadSplitButton.Text = "Mark to Download";
            // 
            // unmarkToDownloadSplitButton
            // 
            this.unmarkToDownloadSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unmarkToDownloadSplitButton.Name = "unmarkToDownloadSplitButton";
            this.unmarkToDownloadSplitButton.Size = new System.Drawing.Size(172, 24);
            this.unmarkToDownloadSplitButton.Text = "UnMark To Download";
            // 
            // processHeadersSplitButton
            // 
            this.processHeadersSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.processHeadersSplitButton.Name = "processHeadersSplitButton";
            this.processHeadersSplitButton.Size = new System.Drawing.Size(190, 24);
            this.processHeadersSplitButton.Text = "Process Marked Headers";
            // 
            // preferencesToolStripEx
            // 
            this.preferencesToolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.preferencesToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.preferencesToolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.preferencesToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.preferencesToolStripEx.Image = null;
            this.preferencesToolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.preferencesToolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadpreferencesButton,
            this.workOfflineButton});
            this.preferencesToolStripEx.Location = new System.Drawing.Point(429, 1);
            this.preferencesToolStripEx.Name = "preferencesToolStripEx";
            this.preferencesToolStripEx.Office12Mode = false;
            this.preferencesToolStripEx.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.preferencesToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.preferencesToolStripEx.Size = new System.Drawing.Size(181, 121);
            this.preferencesToolStripEx.TabIndex = 3;
            this.preferencesToolStripEx.Text = "Preferences";
            this.preferencesToolStripEx.Visible = false;
            // 
            // downloadpreferencesButton
            // 
            this.downloadpreferencesButton.Image = ((System.Drawing.Image)(resources.GetObject("downloadpreferencesButton.Image")));
            this.downloadpreferencesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downloadpreferencesButton.Name = "downloadpreferencesButton";
            this.downloadpreferencesButton.Size = new System.Drawing.Size(83, 113);
            this.downloadpreferencesButton.Text = "Download\r\nPreferences";
            this.downloadpreferencesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // workOfflineButton
            // 
            this.workOfflineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.workOfflineButton.Name = "workOfflineButton";
            this.workOfflineButton.Size = new System.Drawing.Size(53, 113);
            this.workOfflineButton.Text = "Work \r\nOffline";
            this.workOfflineButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // folderTabItem
            // 
            this.folderTabItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTabItem.ForeColor = System.Drawing.Color.Black;
            this.folderTabItem.Name = "folderTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel3
            // 
            this.folderTabItem.Panel.Controls.Add(this.newfoldertoolStripEx);
            this.folderTabItem.Panel.Controls.Add(this.actiontoolStripEx);
            this.folderTabItem.Panel.Controls.Add(this.cleanuptoolStripEx);
            this.folderTabItem.Panel.Controls.Add(this.favoritestoolStrip);
            this.folderTabItem.Panel.Controls.Add(this.onlineviewtoolStripEx);
            this.folderTabItem.Panel.Controls.Add(this.propertiestoolStripEx);
            this.folderTabItem.Panel.Name = "ribbonPanel3";
            this.folderTabItem.Panel.ScrollPosition = 0;
            this.folderTabItem.Panel.TabIndex = 4;
            this.folderTabItem.Panel.Text = "Folder";
            this.folderTabItem.Position = 2;
            this.folderTabItem.Size = new System.Drawing.Size(67, 41);
            this.folderTabItem.Tag = "3";
            this.folderTabItem.Text = "Folder";
            // 
            // newfoldertoolStripEx
            // 
            this.newfoldertoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.newfoldertoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.newfoldertoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.newfoldertoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.newfoldertoolStripEx.Image = null;
            this.newfoldertoolStripEx.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.newfoldertoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFoldertoolStripButton,
            this.newSearchtoolStripButton});
            this.newfoldertoolStripEx.Location = new System.Drawing.Point(0, 1);
            this.newfoldertoolStripEx.Name = "newfoldertoolStripEx";
            this.newfoldertoolStripEx.Office12Mode = false;
            this.newfoldertoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.newfoldertoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newfoldertoolStripEx.Size = new System.Drawing.Size(161, 121);
            this.newfoldertoolStripEx.TabIndex = 0;
            this.newfoldertoolStripEx.Text = "New";
            // 
            // newFoldertoolStripButton
            // 
            this.newFoldertoolStripButton.ForeColor = System.Drawing.Color.Black;
            this.newFoldertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFoldertoolStripButton.Name = "newFoldertoolStripButton";
            this.newFoldertoolStripButton.Size = new System.Drawing.Size(61, 99);
            this.newFoldertoolStripButton.Text = "New\r\nFolder";
            this.newFoldertoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // newSearchtoolStripButton
            // 
            this.newSearchtoolStripButton.ForeColor = System.Drawing.Color.Black;
            this.newSearchtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newSearchtoolStripButton.Name = "newSearchtoolStripButton";
            this.newSearchtoolStripButton.Size = new System.Drawing.Size(94, 99);
            this.newSearchtoolStripButton.Text = "New Search\r\nFolder";
            this.newSearchtoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // actiontoolStripEx
            // 
            this.actiontoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.actiontoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.actiontoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.actiontoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.actiontoolStripEx.Image = null;
            this.actiontoolStripEx.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.actiontoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renamefoldertoolstripButton,
            this.actionPanelItem});
            this.actiontoolStripEx.Location = new System.Drawing.Point(70, 1);
            this.actiontoolStripEx.Name = "actiontoolStripEx";
            this.actiontoolStripEx.Office12Mode = false;
            this.actiontoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.actiontoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.actiontoolStripEx.Size = new System.Drawing.Size(177, 121);
            this.actiontoolStripEx.TabIndex = 1;
            this.actiontoolStripEx.Text = "Action";
            // 
            // renamefoldertoolstripButton
            // 
            this.renamefoldertoolstripButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renamefoldertoolstripButton.ForeColor = System.Drawing.Color.Black;
            this.renamefoldertoolstripButton.Name = "renamefoldertoolstripButton";
            this.renamefoldertoolstripButton.Size = new System.Drawing.Size(62, 99);
            this.renamefoldertoolstripButton.Tag = "2";
            this.renamefoldertoolstripButton.Text = "Rename\r\nFolder";
            this.renamefoldertoolstripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // actionPanelItem
            // 
            this.actionPanelItem.CausesValidation = false;
            this.actionPanelItem.ForeColor = System.Drawing.Color.Black;
            this.actionPanelItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFolderButton,
            this.moveFolderButton,
            this.deleteFolderButton});
            this.actionPanelItem.Name = "actionPanelItem";
            this.actionPanelItem.Size = new System.Drawing.Size(129, 97);
            this.actionPanelItem.Text = "toolStripPanelItem1";
            this.actionPanelItem.Transparent = true;
            // 
            // copyFolderButton
            // 
            this.copyFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyFolderButton.Name = "copyFolderButton";
            this.copyFolderButton.Size = new System.Drawing.Size(115, 28);
            this.copyFolderButton.Text = "Copy Folder";
            // 
            // moveFolderButton
            // 
            this.moveFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveFolderButton.Name = "moveFolderButton";
            this.moveFolderButton.Size = new System.Drawing.Size(118, 28);
            this.moveFolderButton.Text = "Move Folder";
            // 
            // deleteFolderButton
            // 
            this.deleteFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteFolderButton.Name = "deleteFolderButton";
            this.deleteFolderButton.Size = new System.Drawing.Size(125, 28);
            this.deleteFolderButton.Text = "Delete Folder";
            // 
            // cleanuptoolStripEx
            // 
            this.cleanuptoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.cleanuptoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cleanuptoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.cleanuptoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cleanuptoolStripEx.Image = null;
            this.cleanuptoolStripEx.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cleanuptoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAllAsReadButton,
            this.runRulesNowButton,
            this.showAllButton,
            this.cleanUpPanelItem});
            this.cleanuptoolStripEx.Location = new System.Drawing.Point(140, 1);
            this.cleanuptoolStripEx.Name = "cleanuptoolStripEx";
            this.cleanuptoolStripEx.Office12Mode = false;
            this.cleanuptoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cleanuptoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cleanuptoolStripEx.Size = new System.Drawing.Size(408, 121);
            this.cleanuptoolStripEx.TabIndex = 2;
            this.cleanuptoolStripEx.Text = "Clean Up";
            // 
            // markAllAsReadButton
            // 
            this.markAllAsReadButton.ForeColor = System.Drawing.Color.Black;
            this.markAllAsReadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.markAllAsReadButton.Name = "markAllAsReadButton";
            this.markAllAsReadButton.Size = new System.Drawing.Size(64, 99);
            this.markAllAsReadButton.Text = "Mark All\r\nAs Read";
            this.markAllAsReadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // runRulesNowButton
            // 
            this.runRulesNowButton.ForeColor = System.Drawing.Color.Black;
            this.runRulesNowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runRulesNowButton.Name = "runRulesNowButton";
            this.runRulesNowButton.Size = new System.Drawing.Size(73, 99);
            this.runRulesNowButton.Text = "Run Rules\r\nNow";
            this.runRulesNowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // showAllButton
            // 
            this.showAllButton.ForeColor = System.Drawing.Color.Black;
            this.showAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(87, 99);
            this.showAllButton.Text = "Show All\r\nFrom A to Z";
            this.showAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cleanUpPanelItem
            // 
            this.cleanUpPanelItem.CausesValidation = false;
            this.cleanUpPanelItem.ForeColor = System.Drawing.Color.Black;
            this.cleanUpPanelItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanUpFolderDropDowmButton,
            this.deleteAllButton,
            this.recoverDeletedItemSplitButton});
            this.cleanUpPanelItem.Name = "cleanUpPanelItem";
            this.cleanUpPanelItem.Size = new System.Drawing.Size(176, 102);
            this.cleanUpPanelItem.Text = "toolStripPanelItem1";
            this.cleanUpPanelItem.Transparent = true;
            // 
            // cleanUpFolderDropDowmButton
            // 
            this.cleanUpFolderDropDowmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cleanUpFolderDropDowmButton.Name = "cleanUpFolderDropDowmButton";
            this.cleanUpFolderDropDowmButton.Size = new System.Drawing.Size(129, 24);
            this.cleanUpFolderDropDowmButton.Text = "Clean Up Folder";
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(89, 24);
            this.deleteAllButton.Text = "Delete All";
            // 
            // recoverDeletedItemSplitButton
            // 
            this.recoverDeletedItemSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recoverDeletedItemSplitButton.Name = "recoverDeletedItemSplitButton";
            this.recoverDeletedItemSplitButton.Size = new System.Drawing.Size(172, 24);
            this.recoverDeletedItemSplitButton.Text = "Recover Deleted Item";
            // 
            // favoritestoolStrip
            // 
            this.favoritestoolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.favoritestoolStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.favoritestoolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.favoritestoolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.favoritestoolStrip.Image = null;
            this.favoritestoolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.favoritestoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInFavouritesDropDownButton});
            this.favoritestoolStrip.Location = new System.Drawing.Point(210, 1);
            this.favoritestoolStrip.Name = "favoritestoolStrip";
            this.favoritestoolStrip.Office12Mode = false;
            this.favoritestoolStrip.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.favoritestoolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.favoritestoolStrip.Size = new System.Drawing.Size(92, 121);
            this.favoritestoolStrip.TabIndex = 3;
            this.favoritestoolStrip.Text = "Favorites";
            // 
            // showInFavouritesDropDownButton
            // 
            this.showInFavouritesDropDownButton.ForeColor = System.Drawing.Color.Black;
            this.showInFavouritesDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showInFavouritesDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showInFavouritesDropDownButton.Name = "showInFavouritesDropDownButton";
            this.showInFavouritesDropDownButton.Size = new System.Drawing.Size(86, 99);
            this.showInFavouritesDropDownButton.Text = "Show In\r\nFavourites";
            this.showInFavouritesDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // onlineviewtoolStripEx
            // 
            this.onlineviewtoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.onlineviewtoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.onlineviewtoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.onlineviewtoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.onlineviewtoolStripEx.Image = null;
            this.onlineviewtoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.onlineviewtoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOnServerDropDownButton});
            this.onlineviewtoolStripEx.Location = new System.Drawing.Point(262, 1);
            this.onlineviewtoolStripEx.Name = "onlineviewtoolStripEx";
            this.onlineviewtoolStripEx.Office12Mode = false;
            this.onlineviewtoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.onlineviewtoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.onlineviewtoolStripEx.Size = new System.Drawing.Size(81, 121);
            this.onlineviewtoolStripEx.TabIndex = 4;
            this.onlineviewtoolStripEx.Text = "Online View";
            // 
            // viewOnServerDropDownButton
            // 
            this.viewOnServerDropDownButton.ForeColor = System.Drawing.Color.Black;
            this.viewOnServerDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewOnServerDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewOnServerDropDownButton.Name = "viewOnServerDropDownButton";
            this.viewOnServerDropDownButton.Size = new System.Drawing.Size(75, 99);
            this.viewOnServerDropDownButton.Text = "View On\r\nServer";
            this.viewOnServerDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // propertiestoolStripEx
            // 
            this.propertiestoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.propertiestoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.propertiestoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.propertiestoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.propertiestoolStripEx.Image = null;
            this.propertiestoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.propertiestoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoArchieveButton,
            this.folderPermissionDropDownButton,
            this.folderPropertiesButton});
            this.propertiestoolStripEx.Location = new System.Drawing.Point(314, 1);
            this.propertiestoolStripEx.Name = "propertiestoolStripEx";
            this.propertiestoolStripEx.Office12Mode = false;
            this.propertiestoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.propertiestoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.propertiestoolStripEx.Size = new System.Drawing.Size(294, 121);
            this.propertiestoolStripEx.TabIndex = 5;
            this.propertiestoolStripEx.Text = "Properties";
            // 
            // autoArchieveButton
            // 
            this.autoArchieveButton.ForeColor = System.Drawing.Color.Black;
            this.autoArchieveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.autoArchieveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.autoArchieveButton.Name = "autoArchieveButton";
            this.autoArchieveButton.Size = new System.Drawing.Size(109, 99);
            this.autoArchieveButton.Text = "Auto Archeive\r\nSettings";
            this.autoArchieveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // folderPermissionDropDownButton
            // 
            this.folderPermissionDropDownButton.ForeColor = System.Drawing.Color.Black;
            this.folderPermissionDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.folderPermissionDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.folderPermissionDropDownButton.Name = "folderPermissionDropDownButton";
            this.folderPermissionDropDownButton.Size = new System.Drawing.Size(94, 99);
            this.folderPermissionDropDownButton.Text = "Folder\r\nPermissions";
            this.folderPermissionDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // folderPropertiesButton
            // 
            this.folderPropertiesButton.ForeColor = System.Drawing.Color.Black;
            this.folderPropertiesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.folderPropertiesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.folderPropertiesButton.Name = "folderPropertiesButton";
            this.folderPropertiesButton.Size = new System.Drawing.Size(85, 99);
            this.folderPropertiesButton.Text = "Folder\r\nProperties";
            this.folderPropertiesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // viewTabItem
            // 
            this.viewTabItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTabItem.ForeColor = System.Drawing.Color.Black;
            this.viewTabItem.Name = "viewTabItem";
            // 
            // ribbonControlAdv1.ribbonPanel4
            // 
            this.viewTabItem.Panel.Controls.Add(this.currentViewtoolStripEx);
            this.viewTabItem.Panel.Controls.Add(this.messagestoolStripEx);
            this.viewTabItem.Panel.Controls.Add(this.layouttoolStripEx);
            this.viewTabItem.Panel.Controls.Add(this.peoplePanetoolStripEx);
            this.viewTabItem.Panel.Controls.Add(this.windowtoolStripEx);
            this.viewTabItem.Panel.Name = "ribbonPanel4";
            this.viewTabItem.Panel.ScrollPosition = 0;
            this.viewTabItem.Panel.TabIndex = 5;
            this.viewTabItem.Panel.Text = "View";
            this.viewTabItem.Position = 3;
            this.viewTabItem.Size = new System.Drawing.Size(58, 41);
            this.viewTabItem.Tag = "9";
            this.viewTabItem.Text = "View";
            // 
            // currentViewtoolStripEx
            // 
            this.currentViewtoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.currentViewtoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.currentViewtoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.currentViewtoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.currentViewtoolStripEx.Image = null;
            this.currentViewtoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.currentViewtoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeViewSplitButton,
            this.viewSettingDropDownButton,
            this.resetViewButton});
            this.currentViewtoolStripEx.Location = new System.Drawing.Point(0, 1);
            this.currentViewtoolStripEx.Name = "currentViewtoolStripEx";
            this.currentViewtoolStripEx.Office12Mode = false;
            this.currentViewtoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.currentViewtoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentViewtoolStripEx.Size = new System.Drawing.Size(204, 135);
            this.currentViewtoolStripEx.TabIndex = 0;
            this.currentViewtoolStripEx.Text = "Current View";
            // 
            // changeViewSplitButton
            // 
            this.changeViewSplitButton.ForeColor = System.Drawing.Color.Black;
            this.changeViewSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changeViewSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeViewSplitButton.Name = "changeViewSplitButton";
            this.changeViewSplitButton.Size = new System.Drawing.Size(70, 113);
            this.changeViewSplitButton.Text = "Change\r\nView";
            this.changeViewSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // viewSettingDropDownButton
            // 
            this.viewSettingDropDownButton.ForeColor = System.Drawing.Color.Black;
            this.viewSettingDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewSettingDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewSettingDropDownButton.Name = "viewSettingDropDownButton";
            this.viewSettingDropDownButton.Size = new System.Drawing.Size(72, 113);
            this.viewSettingDropDownButton.Text = "View\r\nSettings";
            this.viewSettingDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // resetViewButton
            // 
            this.resetViewButton.ForeColor = System.Drawing.Color.Black;
            this.resetViewButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.resetViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetViewButton.Name = "resetViewButton";
            this.resetViewButton.Size = new System.Drawing.Size(56, 113);
            this.resetViewButton.Text = "Reset\r\nView";
            this.resetViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // messagestoolStripEx
            // 
            this.messagestoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.messagestoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.messagestoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.messagestoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.messagestoolStripEx.Image = null;
            this.messagestoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.messagestoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messagesPanelItem});
            this.messagestoolStripEx.Location = new System.Drawing.Point(52, 1);
            this.messagestoolStripEx.Name = "messagestoolStripEx";
            this.messagestoolStripEx.Office12Mode = false;
            this.messagestoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.messagestoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messagestoolStripEx.Size = new System.Drawing.Size(189, 135);
            this.messagestoolStripEx.TabIndex = 1;
            this.messagestoolStripEx.Text = "Messages";
            // 
            // messagesPanelItem
            // 
            this.messagesPanelItem.CausesValidation = false;
            this.messagesPanelItem.ForeColor = System.Drawing.Color.Black;
            this.messagesPanelItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAsConvesationCheckBox,
            this.conversationSettingSplitButton});
            this.messagesPanelItem.Name = "messagesPanelItem";
            this.messagesPanelItem.Size = new System.Drawing.Size(185, 62);
            this.messagesPanelItem.Text = "toolStripPanelItem8";
            this.messagesPanelItem.Transparent = true;
            // 
            // showAsConvesationCheckBox
            // 
            this.showAsConvesationCheckBox.Name = "showAsConvesationCheckBox";
            this.showAsConvesationCheckBox.Size = new System.Drawing.Size(181, 28);
            this.showAsConvesationCheckBox.Text = "Show As Conversation";
            // 
            // conversationSettingSplitButton
            // 
            this.conversationSettingSplitButton.Enabled = false;
            this.conversationSettingSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.conversationSettingSplitButton.Name = "conversationSettingSplitButton";
            this.conversationSettingSplitButton.Size = new System.Drawing.Size(171, 24);
            this.conversationSettingSplitButton.Text = "Conversation Settings";
            // 
            // layouttoolStripEx
            // 
            this.layouttoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.layouttoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.layouttoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.layouttoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.layouttoolStripEx.Image = null;
            this.layouttoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.layouttoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderPaneSplitButton,
            this.readingPaneSplitButton,
            this.toDoBarSplitButton});
            this.layouttoolStripEx.Location = new System.Drawing.Point(104, 1);
            this.layouttoolStripEx.Name = "layouttoolStripEx";
            this.layouttoolStripEx.Office12Mode = false;
            this.layouttoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.layouttoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.layouttoolStripEx.Size = new System.Drawing.Size(209, 135);
            this.layouttoolStripEx.TabIndex = 2;
            this.layouttoolStripEx.Text = "Layout";
            // 
            // folderPaneSplitButton
            // 
            this.folderPaneSplitButton.ForeColor = System.Drawing.Color.Black;
            this.folderPaneSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.folderPaneSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.folderPaneSplitButton.Name = "folderPaneSplitButton";
            this.folderPaneSplitButton.Size = new System.Drawing.Size(70, 113);
            this.folderPaneSplitButton.Text = "Folder \r\npane";
            this.folderPaneSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // readingPaneSplitButton
            // 
            this.readingPaneSplitButton.ForeColor = System.Drawing.Color.Black;
            this.readingPaneSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.readingPaneSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.readingPaneSplitButton.Name = "readingPaneSplitButton";
            this.readingPaneSplitButton.Size = new System.Drawing.Size(72, 113);
            this.readingPaneSplitButton.Text = "Reading\r\nPane";
            this.readingPaneSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toDoBarSplitButton
            // 
            this.toDoBarSplitButton.ForeColor = System.Drawing.Color.Black;
            this.toDoBarSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toDoBarSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toDoBarSplitButton.Name = "toDoBarSplitButton";
            this.toDoBarSplitButton.Size = new System.Drawing.Size(61, 113);
            this.toDoBarSplitButton.Text = "To-Do\r\nBar";
            this.toDoBarSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // peoplePanetoolStripEx
            // 
            this.peoplePanetoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.peoplePanetoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.peoplePanetoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.peoplePanetoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.peoplePanetoolStripEx.Image = null;
            this.peoplePanetoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.peoplePanetoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peoplePaneSplitButton});
            this.peoplePanetoolStripEx.Location = new System.Drawing.Point(156, 1);
            this.peoplePanetoolStripEx.Name = "peoplePanetoolStripEx";
            this.peoplePanetoolStripEx.Office12Mode = false;
            this.peoplePanetoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.peoplePanetoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.peoplePanetoolStripEx.Size = new System.Drawing.Size(78, 135);
            this.peoplePanetoolStripEx.TabIndex = 3;
            this.peoplePanetoolStripEx.Text = "People Pane";
            // 
            // peoplePaneSplitButton
            // 
            this.peoplePaneSplitButton.ForeColor = System.Drawing.Color.Black;
            this.peoplePaneSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peoplePaneSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.peoplePaneSplitButton.Name = "peoplePaneSplitButton";
            this.peoplePaneSplitButton.Size = new System.Drawing.Size(72, 113);
            this.peoplePaneSplitButton.Text = "People \r\nPane";
            this.peoplePaneSplitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // windowtoolStripEx
            // 
            this.windowtoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.windowtoolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.windowtoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.windowtoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.windowtoolStripEx.Image = null;
            this.windowtoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.windowtoolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remainderWindowButton,
            this.openInNewWIndowButton,
            this.closeAllItemsButton});
            this.windowtoolStripEx.Location = new System.Drawing.Point(208, 1);
            this.windowtoolStripEx.Name = "windowtoolStripEx";
            this.windowtoolStripEx.Office12Mode = false;
            this.windowtoolStripEx.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.windowtoolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowtoolStripEx.Size = new System.Drawing.Size(273, 135);
            this.windowtoolStripEx.TabIndex = 4;
            this.windowtoolStripEx.Text = "Window";
            // 
            // remainderWindowButton
            // 
            this.remainderWindowButton.ForeColor = System.Drawing.Color.Black;
            this.remainderWindowButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.remainderWindowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.remainderWindowButton.Name = "remainderWindowButton";
            this.remainderWindowButton.Size = new System.Drawing.Size(88, 113);
            this.remainderWindowButton.Text = "Remainder\r\nWindow";
            this.remainderWindowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // openInNewWIndowButton
            // 
            this.openInNewWIndowButton.ForeColor = System.Drawing.Color.Black;
            this.openInNewWIndowButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openInNewWIndowButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openInNewWIndowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openInNewWIndowButton.Name = "openInNewWIndowButton";
            this.openInNewWIndowButton.Size = new System.Drawing.Size(104, 113);
            this.openInNewWIndowButton.Text = "Open In\r\nNew Window";
            this.openInNewWIndowButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openInNewWIndowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // closeAllItemsButton
            // 
            this.closeAllItemsButton.ForeColor = System.Drawing.Color.Black;
            this.closeAllItemsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeAllItemsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeAllItemsButton.Name = "closeAllItemsButton";
            this.closeAllItemsButton.Size = new System.Drawing.Size(75, 113);
            this.closeAllItemsButton.Text = "Close All\r\nItems";
            this.closeAllItemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // combotoolStripEx
            // 
            this.combotoolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.combotoolStripEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.combotoolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.combotoolStripEx.Image = null;
            this.combotoolStripEx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.combotoolStripEx.Location = new System.Drawing.Point(1075, 1);
            this.combotoolStripEx.Name = "combotoolStripEx";
            this.combotoolStripEx.Office12Mode = false;
            this.combotoolStripEx.Size = new System.Drawing.Size(182, 101);
            this.combotoolStripEx.TabIndex = 3;
            this.combotoolStripEx.Text = "Preferences";
            this.combotoolStripEx.Visible = false;
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Appearance.AllDayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.scheduleControl1.Appearance.CaptionBackColor = System.Drawing.Color.White;
            this.scheduleControl1.Appearance.ClickItemBorderColor = System.Drawing.Color.Black;
            this.scheduleControl1.Appearance.MonthWeekHeaderForeColor = System.Drawing.Color.White;
            this.scheduleControl1.Appearance.MoreItemArrowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.scheduleControl1.Appearance.NavigationCalendarArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scheduleControl1.Appearance.NavigationCalendarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scheduleControl1.Appearance.NavigationCalendarDisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.scheduleControl1.Appearance.NavigationCalendarHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.scheduleControl1.Appearance.NavigationCalendarSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.scheduleControl1.Appearance.NavigationCalendarTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.scheduleControl1.Appearance.NavigationCalendarTodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(204)))), ((int)(((byte)(196)))));
            this.scheduleControl1.Appearance.NavigationCalendarTodayColor = System.Drawing.Color.Black;
            this.scheduleControl1.Appearance.NavigationCalendarTodayTextColor = System.Drawing.Color.Green;
            this.scheduleControl1.Appearance.NonPrimeTimeCellColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.scheduleControl1.Appearance.PrimeTimeCellColor = System.Drawing.SystemColors.Window;
            this.scheduleControl1.Appearance.SolidBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.scheduleControl1.Appearance.SplitterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.scheduleControl1.Appearance.TimeBackColor = System.Drawing.Color.White;
            this.scheduleControl1.Appearance.TimeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.scheduleControl1.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.scheduleControl1.Appearance.WeekHeaderFormat = "MMMM dd";
            this.scheduleControl1.Appearance.WeekMonthFullFormat = "MMM d, yy";
            this.scheduleControl1.Appearance.WeekMonthNewMonth = "MMM d";
            this.scheduleControl1.Appearance.WorkWeekHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.scheduleControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.scheduleControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl1.DataSource = ((Syncfusion.Schedule.IScheduleDataProvider)(resources.GetObject("scheduleControl1.DataSource")));
            this.scheduleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleControl1.ISO8601CalenderFormat = false;
            this.scheduleControl1.Location = new System.Drawing.Point(0, 0);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.ScheduleType = Syncfusion.Windows.Forms.Schedule.ScheduleViewType.Month;
            this.scheduleControl1.Size = new System.Drawing.Size(1137, 380);
            this.scheduleControl1.TabIndex = 0;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BackColor = System.Drawing.Color.White;
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(1, 192);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.scheduleControl1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1348, 380);
            this.splitContainerAdv1.SplitterDistance = 204;
            this.splitContainerAdv1.TabIndex = 3;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemeName = "None";
            // 
            // tabsimageList
            // 
            this.tabsimageList.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images7"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images8"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images9"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images10"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images11"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images12"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images13"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images14"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images15"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images16"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images17"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images18"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images19"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images20"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images21"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images22"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images23"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images24"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images25"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images26"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images27"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images28"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images29"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images30"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images31"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images32"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images33"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images34"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images35"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images36"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images37"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images38"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images39"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images40"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images41"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images42"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images43"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images44"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images45"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images46"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images47"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images48"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images49"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images50"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images51"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images52"))),
            ((System.Drawing.Image)(resources.GetObject("tabsimageList.Images53")))});
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 573);
            this.Controls.Add(this.backStage1);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Controls.Add(this.splitContainerAdv1);
            this.Name = "CalendarForm";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ShowApplicationIcon = false;
            this.Text = "Calendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backStage1)).EndInit();
            this.backStage1.ResumeLayout(false);
            this.homeTabItem.Panel.ResumeLayout(false);
            this.homeTabItem.Panel.PerformLayout();
            this.newtoolStripEx.ResumeLayout(false);
            this.newtoolStripEx.PerformLayout();
            this.goTotoolStripEx.ResumeLayout(false);
            this.goTotoolStripEx.PerformLayout();
            this.communicatetoolStripEx.ResumeLayout(false);
            this.communicatetoolStripEx.PerformLayout();
            this.sendreceiveTabItem.Panel.ResumeLayout(false);
            this.sendreceiveTabItem.Panel.PerformLayout();
            this.sendreceivetoolStripEx.ResumeLayout(false);
            this.sendreceivetoolStripEx.PerformLayout();
            this.downloadtoolStripEx.ResumeLayout(false);
            this.downloadtoolStripEx.PerformLayout();
            this.servertoolStripEx.ResumeLayout(false);
            this.servertoolStripEx.PerformLayout();
            this.preferencesToolStripEx.ResumeLayout(false);
            this.preferencesToolStripEx.PerformLayout();
            this.folderTabItem.Panel.ResumeLayout(false);
            this.folderTabItem.Panel.PerformLayout();
            this.newfoldertoolStripEx.ResumeLayout(false);
            this.newfoldertoolStripEx.PerformLayout();
            this.actiontoolStripEx.ResumeLayout(false);
            this.actiontoolStripEx.PerformLayout();
            this.cleanuptoolStripEx.ResumeLayout(false);
            this.cleanuptoolStripEx.PerformLayout();
            this.favoritestoolStrip.ResumeLayout(false);
            this.favoritestoolStrip.PerformLayout();
            this.onlineviewtoolStripEx.ResumeLayout(false);
            this.onlineviewtoolStripEx.PerformLayout();
            this.propertiestoolStripEx.ResumeLayout(false);
            this.propertiestoolStripEx.PerformLayout();
            this.viewTabItem.Panel.ResumeLayout(false);
            this.viewTabItem.Panel.PerformLayout();
            this.currentViewtoolStripEx.ResumeLayout(false);
            this.currentViewtoolStripEx.PerformLayout();
            this.messagestoolStripEx.ResumeLayout(false);
            this.messagestoolStripEx.PerformLayout();
            this.layouttoolStripEx.ResumeLayout(false);
            this.layouttoolStripEx.PerformLayout();
            this.peoplePanetoolStripEx.ResumeLayout(false);
            this.peoplePanetoolStripEx.PerformLayout();
            this.windowtoolStripEx.ResumeLayout(false);
            this.windowtoolStripEx.PerformLayout();
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem homeTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx newtoolStripEx;
        private System.Windows.Forms.ToolStripButton newAppointmenttoolStripButton;
        private System.Windows.Forms.ToolStripButton newMeetingToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton newItemstoolStripDropDownButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx goTotoolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx communicatetoolStripEx;
        private System.Windows.Forms.ToolStripButton todayToolStripButton;
        private System.Windows.Forms.ToolStripButton dayToolStripButton;
        private System.Windows.Forms.ToolStripButton workWeekToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAskToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem sendreceiveTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem folderTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx sendreceivetoolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton sendreceivetoolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem sendreceivetoolStripPanelItem;
        private System.Windows.Forms.ToolStripButton UpdateFolderButton;
        private System.Windows.Forms.ToolStripButton SendAllButton;
        private System.Windows.Forms.ToolStripSplitButton SendReceiveGroupsSplit;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx downloadtoolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton showProgresstoolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton cancelAlltoolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx servertoolStripEx;
        private System.Windows.Forms.ToolStripButton downloadHeadersButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem serverPanelItem;
        private System.Windows.Forms.ToolStripSplitButton markToDownloadSplitButton;
        private System.Windows.Forms.ToolStripSplitButton unmarkToDownloadSplitButton;
        private System.Windows.Forms.ToolStripSplitButton processHeadersSplitButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx preferencesToolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx combotoolStripEx;
        private System.Windows.Forms.ToolStripButton downloadpreferencesButton;
        private System.Windows.Forms.ToolStripButton workOfflineButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem viewTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx currentViewtoolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton viewSettingDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton resetViewButton;
        private System.Windows.Forms.ToolStripButton deleteFolderButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx cleanuptoolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem cleanUpPanelItem;
        private System.Windows.Forms.ToolStripDropDownButton cleanUpFolderDropDowmButton;
        private System.Windows.Forms.ToolStripDropDownButton deleteAllButton;
        private System.Windows.Forms.ToolStripSplitButton recoverDeletedItemSplitButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx favoritestoolStrip;
        private System.Windows.Forms.ToolStripDropDownButton showInFavouritesDropDownButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx onlineviewtoolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton viewOnServerDropDownButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx propertiestoolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton autoArchieveButton;
        private System.Windows.Forms.ToolStripDropDownButton folderPermissionDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton folderPropertiesButton;
        private System.Windows.Forms.ToolStripDropDownButton changeViewSplitButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx messagestoolStripEx;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem messagesPanelItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripCheckBox showAsConvesationCheckBox;
        private System.Windows.Forms.ToolStripSplitButton conversationSettingSplitButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx layouttoolStripEx;
        private System.Windows.Forms.ToolStripSplitButton folderPaneSplitButton;
        private System.Windows.Forms.ToolStripDropDownButton readingPaneSplitButton;
        private System.Windows.Forms.ToolStripDropDownButton toDoBarSplitButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx peoplePanetoolStripEx;
        private System.Windows.Forms.ToolStripSplitButton peoplePaneSplitButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx windowtoolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton remainderWindowButton;
        private System.Windows.Forms.ToolStripDropDownButton openInNewWIndowButton;
        private System.Windows.Forms.ToolStripDropDownButton closeAllItemsButton;
        private System.Windows.Forms.ToolStripDropDownButton newFoldertoolStripButton;
        private System.Windows.Forms.ToolStripButton markAllAsReadButton;
        private System.Windows.Forms.ToolStripButton runRulesNowButton;
        private System.Windows.Forms.ToolStripButton showAllButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx newfoldertoolStripEx;
        private System.Windows.Forms.ToolStripDropDownButton newSearchtoolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx actiontoolStripEx;
        private System.Windows.Forms.ToolStripButton renamefoldertoolstripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem actionPanelItem;
        private System.Windows.Forms.ToolStripButton copyFolderButton;
        private System.Windows.Forms.ToolStripButton moveFolderButton;
        private System.Windows.Forms.ToolStripButton nextDaystoolStripButton;
        private System.Windows.Forms.ToolStripButton weektoolStripButton;
        private System.Windows.Forms.ToolStripButton monthtoolStripButton;
        private System.Windows.Forms.ToolStripButton scheduleViewtoolStripButton;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv tabsimageList;
        private BackStageView backStageView1;
        private BackStage backStage1;
        private BackStageTab infobackStageTab;
    }

}

