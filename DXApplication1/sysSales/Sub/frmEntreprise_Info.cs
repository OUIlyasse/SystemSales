using SalesDB.DB;
using SalesDB.Proc_DB;
using sysSales.IForms;
using System;
using System.Linq;

namespace sysSales.Sub
{
    public partial class frmEntreprise_Info : IFrm
    {
        #region Varibales
        private SystemSalesEntities db = new SystemSalesEntities();
        private CRUD<Entreprise_Info> en = new CRUD<Entreprise_Info>();
        private Entreprise_Info ent;

        #endregion Varibales

        #region myCodes
        private string getCode()
        {
            return "";
        }
        private string getMaxID()
        {
            var max = db.Entreprise_Info.Any() ? db.Entreprise_Info.Max(x => x.entr_ID) + 1 : 1;
            return max.ToString();
        }
        #endregion myCodes

        #region Override
        public override void Data_Add(SystemSalesEntities T)
        {
            if (vp.Validate())
            {
                ent = new Entreprise_Info();
                ent.entr_ID = Convert.ToDecimal(getMaxID());
                ent.entr_Code = getCode();
                ent.entr_Nom = txtName.Text;
                ent.entr_Adresse1 = txtA1.Text;
                ent.entr_Adresse2 = txtA2.Text;
                ent.entr_Mobile1 = txtM1.Text;
                ent.entr_Mobile2 = txtM2.Text;
                ent.entr_Fixe1 = txtFi1.Text;
                ent.entr_Fixe2 = txtFi2.Text;
                ent.entr_Fax1 = txtFa1.Text;
                ent.entr_Fax2 = txtFa2.Text;
                ent.entr_Email = txtEmail.Text;
                //ent.entr_Image = getCode();
                ent.entr_Note = txtNote.Text;
            }
            base.Data_Add(T);
        }
        #endregion Override
        public frmEntreprise_Info()
        {
            InitializeComponent();
            txtCode.Text = getMaxID();
        }

        private void frmEntreprise_Info_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}