//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class offer
    {
        public int Offer_id { get; set; }
        public Nullable<System.DateTime> From_Date { get; set; }
        public Nullable<System.DateTime> To_Date { get; set; }
        public Nullable<int> PMS_ID { get; set; }
        public Nullable<int> user_id { get; set; }
        public string offer_name { get; set; }
        public bool is_active { get; set; }
        public string description { get; set; }
    }
}
