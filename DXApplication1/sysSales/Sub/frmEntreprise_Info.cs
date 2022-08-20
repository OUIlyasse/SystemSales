using SalesDB.DB;
using SalesDB.Proc_DB;
using sysSales.IForms;
using System;
using System.Linq;
using System.Windows.Forms;
using static myTools.Tools;

namespace sysSales.Sub
{
    public partial class frmEntreprise_Info : IFrm
    {
        #region Varibales
        private CRUD<Entreprise_Info> crd = new CRUD<Entreprise_Info>();
        private SystemSalesEntities db = new SystemSalesEntities();
        private Entreprise_Info ent;

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
        public override void Data_Add()
        {
            try
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
                    if (crd.Add(ent))
                    {
                        refreshData();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ILmsgBox(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.Data_Add();
        }
        #endregion Override
        public frmEntreprise_Info()
        {
            InitializeComponent();
            txtCode.Text = getCode();
        }
    }
}