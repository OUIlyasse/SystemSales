using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Schedule;

namespace Sales
{
     public partial class CalendarForm : RibbonForm
    {
        public CalendarForm()
        {
            InitializeComponent();
            // Schedule functions
            this.dayToolStripButton.Click += new EventHandler(email_Click);
            this.workWeekToolStripButton.Click += new EventHandler(meeting_Click);
            this.weektoolStripButton.Click += new EventHandler(weektoolStripButton_Click);
            this.monthtoolStripButton.Click += new EventHandler(monthtoolStripButton_Click);

            //Assigns images for the tabs
            AssignImageforHomeTab();
            AssignImageforSendTab();
            AssignImageforFolderTab();
            AssignImageforViewTab();
        }

        #region Schedule functions
        void monthtoolStripButton_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month);
        }

        void weektoolStripButton_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week);
        }

        void meeting_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek);
        }

        void email_Click(object sender, EventArgs e)
        {
            this.scheduleControl1.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day);
        }

        #endregion

        #region Images for ToolStrip items
        //Assigns images for the Home tab items
        private void AssignImageforHomeTab()
        {
            this.newAppointmenttoolStripButton.Image = this.tabsimageList.Images[24];
            this.newMeetingToolStripButton.Image = this.tabsimageList.Images[25];
            this.newItemstoolStripDropDownButton.Image = this.tabsimageList.Images[26];
            this.todayToolStripButton.Image = this.tabsimageList.Images[27];
            this.nextDaystoolStripButton.Image = this.tabsimageList.Images[28];
            this.dayToolStripButton.Image = this.tabsimageList.Images[29];
            this.workWeekToolStripButton.Image = this.tabsimageList.Images[30];
            this.weektoolStripButton.Image = this.tabsimageList.Images[31];
            this.monthtoolStripButton.Image = this.tabsimageList.Images[32];
            this.scheduleViewtoolStripButton.Image = this.tabsimageList.Images[33];
        }
        //Assigns images for the Send tab items
        private void AssignImageforSendTab()
        {
            this.sendreceivetoolStripButton.Image = this.tabsimageList.Images[42];
            this.UpdateFolderButton.Image = this.tabsimageList.Images[51];
            this.SendAllButton.Image = this.tabsimageList.Images[41];
            this.SendReceiveGroupsSplit.Image = this.tabsimageList.Images[43];
            this.cancelAlltoolStripButton.Image = this.tabsimageList.Images[3];
            this.showProgresstoolStripButton.Image = this.tabsimageList.Images[47];
        }
        //Assigns images for the Folder tab items
        private void AssignImageforFolderTab()
        {
            this.newFoldertoolStripButton.Image = this.tabsimageList.Images[20];
            this.newSearchtoolStripButton.Image = this.tabsimageList.Images[22];
            this.renamefoldertoolstripButton.Image = this.tabsimageList.Images[36];
            this.copyFolderButton.Image = this.tabsimageList.Images[38];
            this.moveFolderButton.Image = this.tabsimageList.Images[19];
            this.deleteFolderButton.Image = this.tabsimageList.Images[8];
            this.markAllAsReadButton.Image = this.tabsimageList.Images[16];
            this.runRulesNowButton.Image = this.tabsimageList.Images[40];
            this.showAllButton.Image = this.tabsimageList.Images[45];
            this.cleanUpFolderDropDowmButton.Image = this.tabsimageList.Images[6];
            this.deleteAllButton.Image = this.tabsimageList.Images[8];
            this.recoverDeletedItemSplitButton.Image = this.tabsimageList.Images[50];
            this.showInFavouritesDropDownButton.Image = this.tabsimageList.Images[46];
            this.viewOnServerDropDownButton.Image = this.tabsimageList.Images[52];
            this.autoArchieveButton.Image = this.tabsimageList.Images[2];
            this.folderPermissionDropDownButton.Image = this.tabsimageList.Images[11];
            this.folderPropertiesButton.Image = this.tabsimageList.Images[12];
        }
        //Assigns images for the View tab items
        private void AssignImageforViewTab()
        {
            this.changeViewSplitButton.Image = this.tabsimageList.Images[5];
            this.viewSettingDropDownButton.Image = this.tabsimageList.Images[53];
            this.resetViewButton.Image = this.tabsimageList.Images[37];
            this.conversationSettingSplitButton.Image = this.tabsimageList.Images[37];
            this.folderPaneSplitButton.Image = this.tabsimageList.Images[9];
            this.readingPaneSplitButton.Image = this.tabsimageList.Images[34];
            this.toDoBarSplitButton.Image = this.tabsimageList.Images[49];
            this.peoplePaneSplitButton.Image = this.tabsimageList.Images[17];
            this.remainderWindowButton.Image = this.tabsimageList.Images[35];
            this.openInNewWIndowButton.Image = this.tabsimageList.Images[23];
            this.closeAllItemsButton.Image = this.tabsimageList.Images[7];
        }
        #endregion
    }
}
