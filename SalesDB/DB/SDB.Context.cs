//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesDB.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SystemSalesEntities : DbContext
    {
        public SystemSalesEntities()
            : base("name=SystemSalesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banque> Banques { get; set; }
        public virtual DbSet<Bon_Destruction> Bon_Destruction { get; set; }
        public virtual DbSet<Bon_Destruction_Produit> Bon_Destruction_Produit { get; set; }
        public virtual DbSet<Bon_Entree> Bon_Entree { get; set; }
        public virtual DbSet<Bon_Entree_Produit> Bon_Entree_Produit { get; set; }
        public virtual DbSet<Bon_Sortie> Bon_Sortie { get; set; }
        public virtual DbSet<Bon_Sortie_Produit> Bon_Sortie_Produit { get; set; }
        public virtual DbSet<Bon_Type> Bon_Type { get; set; }
        public virtual DbSet<Branche> Branches { get; set; }
        public virtual DbSet<Charge> Charges { get; set; }
        public virtual DbSet<Charge_Type> Charge_Type { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Compte_Bancaire> Compte_Bancaire { get; set; }
        public virtual DbSet<Compte_Charge> Compte_Charge { get; set; }
        public virtual DbSet<Compte_Client> Compte_Client { get; set; }
        public virtual DbSet<Compte_Employee> Compte_Employee { get; set; }
        public virtual DbSet<Compte_Espece> Compte_Espece { get; set; }
        public virtual DbSet<Compte_Fournisseur> Compte_Fournisseur { get; set; }
        public virtual DbSet<Compte_Local> Compte_Local { get; set; }
        public virtual DbSet<Compte_Local_Type> Compte_Local_Type { get; set; }
        public virtual DbSet<Devise> Devises { get; set; }
        public virtual DbSet<Devise_Banque> Devise_Banque { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Salaire> Employee_Salaire { get; set; }
        public virtual DbSet<Entreprise_Info> Entreprise_Info { get; set; }
        public virtual DbSet<Facture_Achat> Facture_Achat { get; set; }
        public virtual DbSet<Facture_Achat_Bonus> Facture_Achat_Bonus { get; set; }
        public virtual DbSet<Facture_Achat_Produit> Facture_Achat_Produit { get; set; }
        public virtual DbSet<Facture_Achat_Produit_Retour> Facture_Achat_Produit_Retour { get; set; }
        public virtual DbSet<Facture_Achat_Retour> Facture_Achat_Retour { get; set; }
        public virtual DbSet<Facture_Paiement_Type> Facture_Paiement_Type { get; set; }
        public virtual DbSet<Facture_Type> Facture_Type { get; set; }
        public virtual DbSet<Facture_Vente> Facture_Vente { get; set; }
        public virtual DbSet<Facture_Vente_Bonus> Facture_Vente_Bonus { get; set; }
        public virtual DbSet<Facture_Vente_Produit> Facture_Vente_Produit { get; set; }
        public virtual DbSet<Facture_Vente_Produit_Retour> Facture_Vente_Produit_Retour { get; set; }
        public virtual DbSet<Facture_Vente_Retour> Facture_Vente_Retour { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<Impot> Impots { get; set; }
        public virtual DbSet<Magasin> Magasins { get; set; }
        public virtual DbSet<Magasin_Branche> Magasin_Branche { get; set; }
        public virtual DbSet<Main_Caisse> Main_Caisse { get; set; }
        public virtual DbSet<Operation_Bon_Entree_Magasin> Operation_Bon_Entree_Magasin { get; set; }
        public virtual DbSet<Operation_Bon_Sortie_Magasin> Operation_Bon_Sortie_Magasin { get; set; }
        public virtual DbSet<Operation_Caisse> Operation_Caisse { get; set; }
        public virtual DbSet<Operation_Facture_Achat> Operation_Facture_Achat { get; set; }
        public virtual DbSet<Operation_Facture_Achat_Retour> Operation_Facture_Achat_Retour { get; set; }
        public virtual DbSet<Operation_Facture_Vente> Operation_Facture_Vente { get; set; }
        public virtual DbSet<Operation_Facture_Vente_Retour> Operation_Facture_Vente_Retour { get; set; }
        public virtual DbSet<Operation_Impot> Operation_Impot { get; set; }
        public virtual DbSet<Operation_Recu_Achat> Operation_Recu_Achat { get; set; }
        public virtual DbSet<Operation_Recu_Vente> Operation_Recu_Vente { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Produit_Barcode> Produit_Barcode { get; set; }
        public virtual DbSet<Produit_Boxe> Produit_Boxe { get; set; }
        public virtual DbSet<Produit_Categorie> Produit_Categorie { get; set; }
        public virtual DbSet<Produit_Detail> Produit_Detail { get; set; }
        public virtual DbSet<Produit_Emplacement> Produit_Emplacement { get; set; }
        public virtual DbSet<Produit_Image> Produit_Image { get; set; }
        public virtual DbSet<Produit_Section> Produit_Section { get; set; }
        public virtual DbSet<Produit_Type> Produit_Type { get; set; }
        public virtual DbSet<Recu_Achat> Recu_Achat { get; set; }
        public virtual DbSet<Recu_Type> Recu_Type { get; set; }
        public virtual DbSet<Recu_Vente> Recu_Vente { get; set; }
        public virtual DbSet<Traitement> Traitements { get; set; }
        public virtual DbSet<Unite_Mesure> Unite_Mesure { get; set; }
        public virtual DbSet<Unite_Type> Unite_Type { get; set; }
    
        public virtual ObjectResult<Select_Branche_Result1> Select_Branche()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_Branche_Result1>("Select_Branche");
        }
    
        public virtual int Delete_Branche(Nullable<decimal> barn_ID)
        {
            var barn_IDParameter = barn_ID.HasValue ?
                new ObjectParameter("barn_ID", barn_ID) :
                new ObjectParameter("barn_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Branche", barn_IDParameter);
        }
    
        public virtual int Insert_Branche(Nullable<decimal> barn_ID, string barn_Code, string barn_Nom, string barn_Mobile, string barn_Fixe, string barn_Adresse, Nullable<System.DateTime> barn_Date_Creation, Nullable<int> barn_Status, string barn_Note, Nullable<decimal> entr_ID)
        {
            var barn_IDParameter = barn_ID.HasValue ?
                new ObjectParameter("barn_ID", barn_ID) :
                new ObjectParameter("barn_ID", typeof(decimal));
    
            var barn_CodeParameter = barn_Code != null ?
                new ObjectParameter("barn_Code", barn_Code) :
                new ObjectParameter("barn_Code", typeof(string));
    
            var barn_NomParameter = barn_Nom != null ?
                new ObjectParameter("barn_Nom", barn_Nom) :
                new ObjectParameter("barn_Nom", typeof(string));
    
            var barn_MobileParameter = barn_Mobile != null ?
                new ObjectParameter("barn_Mobile", barn_Mobile) :
                new ObjectParameter("barn_Mobile", typeof(string));
    
            var barn_FixeParameter = barn_Fixe != null ?
                new ObjectParameter("barn_Fixe", barn_Fixe) :
                new ObjectParameter("barn_Fixe", typeof(string));
    
            var barn_AdresseParameter = barn_Adresse != null ?
                new ObjectParameter("barn_Adresse", barn_Adresse) :
                new ObjectParameter("barn_Adresse", typeof(string));
    
            var barn_Date_CreationParameter = barn_Date_Creation.HasValue ?
                new ObjectParameter("barn_Date_Creation", barn_Date_Creation) :
                new ObjectParameter("barn_Date_Creation", typeof(System.DateTime));
    
            var barn_StatusParameter = barn_Status.HasValue ?
                new ObjectParameter("barn_Status", barn_Status) :
                new ObjectParameter("barn_Status", typeof(int));
    
            var barn_NoteParameter = barn_Note != null ?
                new ObjectParameter("barn_Note", barn_Note) :
                new ObjectParameter("barn_Note", typeof(string));
    
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Branche", barn_IDParameter, barn_CodeParameter, barn_NomParameter, barn_MobileParameter, barn_FixeParameter, barn_AdresseParameter, barn_Date_CreationParameter, barn_StatusParameter, barn_NoteParameter, entr_IDParameter);
        }
    
        public virtual int Update_Branche(Nullable<decimal> barn_ID, string barn_Code, string barn_Nom, string barn_Mobile, string barn_Fixe, string barn_Adresse, Nullable<System.DateTime> barn_Date_Creation, Nullable<int> barn_Status, string barn_Note, Nullable<decimal> entr_ID)
        {
            var barn_IDParameter = barn_ID.HasValue ?
                new ObjectParameter("barn_ID", barn_ID) :
                new ObjectParameter("barn_ID", typeof(decimal));
    
            var barn_CodeParameter = barn_Code != null ?
                new ObjectParameter("barn_Code", barn_Code) :
                new ObjectParameter("barn_Code", typeof(string));
    
            var barn_NomParameter = barn_Nom != null ?
                new ObjectParameter("barn_Nom", barn_Nom) :
                new ObjectParameter("barn_Nom", typeof(string));
    
            var barn_MobileParameter = barn_Mobile != null ?
                new ObjectParameter("barn_Mobile", barn_Mobile) :
                new ObjectParameter("barn_Mobile", typeof(string));
    
            var barn_FixeParameter = barn_Fixe != null ?
                new ObjectParameter("barn_Fixe", barn_Fixe) :
                new ObjectParameter("barn_Fixe", typeof(string));
    
            var barn_AdresseParameter = barn_Adresse != null ?
                new ObjectParameter("barn_Adresse", barn_Adresse) :
                new ObjectParameter("barn_Adresse", typeof(string));
    
            var barn_Date_CreationParameter = barn_Date_Creation.HasValue ?
                new ObjectParameter("barn_Date_Creation", barn_Date_Creation) :
                new ObjectParameter("barn_Date_Creation", typeof(System.DateTime));
    
            var barn_StatusParameter = barn_Status.HasValue ?
                new ObjectParameter("barn_Status", barn_Status) :
                new ObjectParameter("barn_Status", typeof(int));
    
            var barn_NoteParameter = barn_Note != null ?
                new ObjectParameter("barn_Note", barn_Note) :
                new ObjectParameter("barn_Note", typeof(string));
    
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Branche", barn_IDParameter, barn_CodeParameter, barn_NomParameter, barn_MobileParameter, barn_FixeParameter, barn_AdresseParameter, barn_Date_CreationParameter, barn_StatusParameter, barn_NoteParameter, entr_IDParameter);
        }
    
        public virtual int Delete_Entreprise_Info(Nullable<decimal> entr_ID)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Entreprise_Info", entr_IDParameter);
        }
    
        public virtual int Insert_Entreprise_Info(Nullable<decimal> entr_ID, string entr_Code, string entr_Nom, string entr_Adresse1, string entr_Adresse2, string entr_Mobile1, string entr_Mobile2, string entr_Mobile3, string entr_Fixe1, string entr_Fixe2, string entr_Fixe3, string entr_Fax1, string entr_Fax2, string entr_Email, string entr_Note)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(decimal));
    
            var entr_CodeParameter = entr_Code != null ?
                new ObjectParameter("entr_Code", entr_Code) :
                new ObjectParameter("entr_Code", typeof(string));
    
            var entr_NomParameter = entr_Nom != null ?
                new ObjectParameter("entr_Nom", entr_Nom) :
                new ObjectParameter("entr_Nom", typeof(string));
    
            var entr_Adresse1Parameter = entr_Adresse1 != null ?
                new ObjectParameter("entr_Adresse1", entr_Adresse1) :
                new ObjectParameter("entr_Adresse1", typeof(string));
    
            var entr_Adresse2Parameter = entr_Adresse2 != null ?
                new ObjectParameter("entr_Adresse2", entr_Adresse2) :
                new ObjectParameter("entr_Adresse2", typeof(string));
    
            var entr_Mobile1Parameter = entr_Mobile1 != null ?
                new ObjectParameter("entr_Mobile1", entr_Mobile1) :
                new ObjectParameter("entr_Mobile1", typeof(string));
    
            var entr_Mobile2Parameter = entr_Mobile2 != null ?
                new ObjectParameter("entr_Mobile2", entr_Mobile2) :
                new ObjectParameter("entr_Mobile2", typeof(string));
    
            var entr_Mobile3Parameter = entr_Mobile3 != null ?
                new ObjectParameter("entr_Mobile3", entr_Mobile3) :
                new ObjectParameter("entr_Mobile3", typeof(string));
    
            var entr_Fixe1Parameter = entr_Fixe1 != null ?
                new ObjectParameter("entr_Fixe1", entr_Fixe1) :
                new ObjectParameter("entr_Fixe1", typeof(string));
    
            var entr_Fixe2Parameter = entr_Fixe2 != null ?
                new ObjectParameter("entr_Fixe2", entr_Fixe2) :
                new ObjectParameter("entr_Fixe2", typeof(string));
    
            var entr_Fixe3Parameter = entr_Fixe3 != null ?
                new ObjectParameter("entr_Fixe3", entr_Fixe3) :
                new ObjectParameter("entr_Fixe3", typeof(string));
    
            var entr_Fax1Parameter = entr_Fax1 != null ?
                new ObjectParameter("entr_Fax1", entr_Fax1) :
                new ObjectParameter("entr_Fax1", typeof(string));
    
            var entr_Fax2Parameter = entr_Fax2 != null ?
                new ObjectParameter("entr_Fax2", entr_Fax2) :
                new ObjectParameter("entr_Fax2", typeof(string));
    
            var entr_EmailParameter = entr_Email != null ?
                new ObjectParameter("entr_Email", entr_Email) :
                new ObjectParameter("entr_Email", typeof(string));
    
            var entr_NoteParameter = entr_Note != null ?
                new ObjectParameter("entr_Note", entr_Note) :
                new ObjectParameter("entr_Note", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Entreprise_Info", entr_IDParameter, entr_CodeParameter, entr_NomParameter, entr_Adresse1Parameter, entr_Adresse2Parameter, entr_Mobile1Parameter, entr_Mobile2Parameter, entr_Mobile3Parameter, entr_Fixe1Parameter, entr_Fixe2Parameter, entr_Fixe3Parameter, entr_Fax1Parameter, entr_Fax2Parameter, entr_EmailParameter, entr_NoteParameter);
        }
    
        public virtual int Update_Entreprise_Info(Nullable<decimal> entr_ID, string entr_Code, string entr_Nom, string entr_Adresse1, string entr_Adresse2, string entr_Mobile1, string entr_Mobile2, string entr_Mobile3, string entr_Fixe1, string entr_Fixe2, string entr_Fixe3, string entr_Fax1, string entr_Fax2, string entr_Email, string entr_Note)
        {
            var entr_IDParameter = entr_ID.HasValue ?
                new ObjectParameter("entr_ID", entr_ID) :
                new ObjectParameter("entr_ID", typeof(decimal));
    
            var entr_CodeParameter = entr_Code != null ?
                new ObjectParameter("entr_Code", entr_Code) :
                new ObjectParameter("entr_Code", typeof(string));
    
            var entr_NomParameter = entr_Nom != null ?
                new ObjectParameter("entr_Nom", entr_Nom) :
                new ObjectParameter("entr_Nom", typeof(string));
    
            var entr_Adresse1Parameter = entr_Adresse1 != null ?
                new ObjectParameter("entr_Adresse1", entr_Adresse1) :
                new ObjectParameter("entr_Adresse1", typeof(string));
    
            var entr_Adresse2Parameter = entr_Adresse2 != null ?
                new ObjectParameter("entr_Adresse2", entr_Adresse2) :
                new ObjectParameter("entr_Adresse2", typeof(string));
    
            var entr_Mobile1Parameter = entr_Mobile1 != null ?
                new ObjectParameter("entr_Mobile1", entr_Mobile1) :
                new ObjectParameter("entr_Mobile1", typeof(string));
    
            var entr_Mobile2Parameter = entr_Mobile2 != null ?
                new ObjectParameter("entr_Mobile2", entr_Mobile2) :
                new ObjectParameter("entr_Mobile2", typeof(string));
    
            var entr_Mobile3Parameter = entr_Mobile3 != null ?
                new ObjectParameter("entr_Mobile3", entr_Mobile3) :
                new ObjectParameter("entr_Mobile3", typeof(string));
    
            var entr_Fixe1Parameter = entr_Fixe1 != null ?
                new ObjectParameter("entr_Fixe1", entr_Fixe1) :
                new ObjectParameter("entr_Fixe1", typeof(string));
    
            var entr_Fixe2Parameter = entr_Fixe2 != null ?
                new ObjectParameter("entr_Fixe2", entr_Fixe2) :
                new ObjectParameter("entr_Fixe2", typeof(string));
    
            var entr_Fixe3Parameter = entr_Fixe3 != null ?
                new ObjectParameter("entr_Fixe3", entr_Fixe3) :
                new ObjectParameter("entr_Fixe3", typeof(string));
    
            var entr_Fax1Parameter = entr_Fax1 != null ?
                new ObjectParameter("entr_Fax1", entr_Fax1) :
                new ObjectParameter("entr_Fax1", typeof(string));
    
            var entr_Fax2Parameter = entr_Fax2 != null ?
                new ObjectParameter("entr_Fax2", entr_Fax2) :
                new ObjectParameter("entr_Fax2", typeof(string));
    
            var entr_EmailParameter = entr_Email != null ?
                new ObjectParameter("entr_Email", entr_Email) :
                new ObjectParameter("entr_Email", typeof(string));
    
            var entr_NoteParameter = entr_Note != null ?
                new ObjectParameter("entr_Note", entr_Note) :
                new ObjectParameter("entr_Note", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Entreprise_Info", entr_IDParameter, entr_CodeParameter, entr_NomParameter, entr_Adresse1Parameter, entr_Adresse2Parameter, entr_Mobile1Parameter, entr_Mobile2Parameter, entr_Mobile3Parameter, entr_Fixe1Parameter, entr_Fixe2Parameter, entr_Fixe3Parameter, entr_Fax1Parameter, entr_Fax2Parameter, entr_EmailParameter, entr_NoteParameter);
        }
    }
}
