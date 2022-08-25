using SalesDB.DB;
using SalesDB.Proc_DB;
using sysSales.IForms;
using sysSales.Main;
using System;
using System.Linq;
using static myTools.Tools;

namespace sysSales.Sub
{
    public partial class frmEntreprise_Info : IFrm
    {
        #region Varibales
        private CRUD<Entreprise_Info> crd = new CRUD<Entreprise_Info>();
        private SystemSalesEntities db = new SystemSalesEntities();
        private Entreprise_Info ent;
        private frmMain fm;
        #endregion Varibales

        #region myCodes
        private string getCode()
        {
            return string.Format("COM{0:0000}{1}{2}", Convert.ToDecimal(getMaxID()), GetDateTime().ToString("dd"), GetDateTime().ToString("MM"));
        }
        private string getMaxID()
        {
            var max = db.Entreprise_Info.Any() ? db.Entreprise_Info.Max(x => x.entr_ID) + 1 : 1;
            return max.ToString();
        }
        private void refreshData()
        {
            throw new NotImplementedException();
        }
        #endregion myCodes

        #region Override
        public override void Data_Add(string msg)
        {
            try
            {
                if (vp.Validate())
                {
                    var ID = Convert.ToDecimal(getMaxID());
                    var Code = getCode();
                    var Nom = txtName.Text;
                    var Adresse1 = txtA1.Text;
                    var Adresse2 = txtA2.Text;
                    var Mobile1 = txtM1.Text;
                    var Mobile2 = txtM2.Text;
                    var Mobile3 = txtM3.Text;
                    var Fixe1 = txtFi1.Text;
                    var Fixe2 = txtFi2.Text;
                    var Fixe3 = txtFi3.Text;
                    var Fax1 = txtFa1.Text;
                    var Fax2 = txtFa2.Text;
                    var Email = txtEmail.Text;
                    //ent.entr_Image = getCode();
                    var Note = txtNote.Text;
                    if (db.Insert_Entreprise_Info(ID, Code, Nom, Adresse1, Adresse2, Mobile1, Mobile2, Mobile3, Fixe1, Fixe2, Fixe3, Fax1, Fax2, Email, Note) > 0)
                        base.Data_Add("Data added successfully");
                    else
                        base.Data_Add("The name field already exists");
                }
            }
            catch (Exception ex)
            {
                base.Data_Add(ex.Message);
            }
        }
        #endregion Override
        public frmEntreprise_Info(frmMain fm)
            : base(fm)
        {
            InitializeComponent();
            this.fm = fm;
            txtCode.Text = getCode();
        }
    }
}