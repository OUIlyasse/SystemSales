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
    
    public partial class Operation_Recu_Vente
    {
        public decimal recu_V_O_ID { get; set; }
        public string recu_V_O_Code { get; set; }
        public Nullable<System.DateTime> recu_V_O_Date { get; set; }
        public Nullable<System.TimeSpan> recu_V_O_Temps { get; set; }
        public string recu_V_O_Text { get; set; }
        public Nullable<decimal> recu_V_ID { get; set; }
        public Nullable<decimal> recu_V_O_Montant { get; set; }
        public Nullable<decimal> recu_V_O_Remise { get; set; }
        public Nullable<decimal> recu_V_O_Total { get; set; }
        public Nullable<decimal> recu_V_O_Net { get; set; }
        public Nullable<decimal> dvs_ID { get; set; }
        public Nullable<decimal> barn_ID { get; set; }
        public Nullable<bool> recu_V_O_Status { get; set; }
        public string recu_V_O_Note { get; set; }
    
        public virtual Branche Branche { get; set; }
        public virtual Devise Devise { get; set; }
        public virtual Recu_Vente Recu_Vente { get; set; }
    }
}
