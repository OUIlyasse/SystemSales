﻿using DevExpress.XtraEditors;
using SalesDB.DB;
using sysSales.Main;
using System;
using System.Collections;
using System.Linq.Expressions;
using static myTools.Tools;

namespace sysSales.IForms
{
    public partial class IFrmList : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private XtraForm form;
        #endregion Variables
        #region Codes
        public virtual void getData()
        {
        }
        public virtual void showForm(XtraForm form)
        {
            form.ShowDialog();
        }
        #endregion Codes
        public IFrmList()
        {
            InitializeComponent();
            //getData();
        }
        public IFrmList(bool t, XtraForm form)
        {
            InitializeComponent();
            this.t = t;
            this.form = form;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            showForm(form);
        }

        private void IFrmList_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}