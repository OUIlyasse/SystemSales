using SalesDB.DB;
using sysSales.IForms;

namespace sysSales.Sub
{
    public partial class frmEntreprise_Info : IFrm
    {
        #region Varibales
        private SystemSalesEntities db = new SystemSalesEntities();
        private Entreprise_Info ent;
        #endregion Varibales

        #region myCodes
        private string getCode()
        {
            return "";
        }
        private string getMaxID()
        {
            var result = db.MaxID_Entreprise_Info();
            return result.ToString();
        }
        #endregion myCodes

        #region Override
        //public override void Data_Add(SalesSystemEntities T)
        //{
        //    if (vp.Validate())
        //    {
        //        ent = new Entreprise_Info();
        //        ent.entr_ID = Convert.ToDecimal(getMaxID());
        //        ent.entr_Code = getCode();
        //        ent.entr_Nom = txtNom.Text;
        //        ent.entr_Adresse1 = txtAddress1.Text;
        //        ent.entr_Adresse2 = txtAddress2.Text;
        //        ent.entr_Mobile1 = txtMobile1.Text;
        //        ent.entr_Mobile2 = txtMobile2.Text;
        //        ent.entr_Fixe1 = txtFixe1.Text;
        //        ent.entr_fixe2 = txtFixe2.Text;
        //        ent.entr_Fax1 = txtFax1.Text;
        //        ent.entr_Fax2 = txtFax2.Text;
        //        ent.entr_Email = txtEmail.Text;
        //        //ent.entr_Image = getCode();
        //        ent.entr_Note = txtNote.Text;
        //    }
        //    base.Data_Add(T);
        //}
        #endregion Override
        public frmEntreprise_Info()
        {
            InitializeComponent();
        }
    }
}