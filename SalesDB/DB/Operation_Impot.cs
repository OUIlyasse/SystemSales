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
    using System.Collections.Generic;
    
    public partial class Operation_Impot
    {
        public decimal imp_O_ID { get; set; }
        public string imp_O_Code { get; set; }
        public Nullable<System.DateTime> imp_O_Date { get; set; }
        public Nullable<System.TimeSpan> imp_O_Temps { get; set; }
        public Nullable<decimal> imp_O_Montant_tva { get; set; }
        public Nullable<decimal> imp_O_Valeur_tva { get; set; }
        public Nullable<decimal> imp_O_Net { get; set; }
        public Nullable<decimal> imp_ID { get; set; }
        public Nullable<bool> imp_O_Status { get; set; }
        public string imp_O_Note { get; set; }
    
        public virtual Impot Impot { get; set; }
    }
}
