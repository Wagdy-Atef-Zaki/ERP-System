//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITI_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purch_Retern_Table
    {
        public Purch_Retern_Table()
        {
            this.Payback_Purch_Retern_Table = new HashSet<Payback_Purch_Retern_Table>();
            this.Purch_Retern_Details_Table = new HashSet<Purch_Retern_Details_Table>();
        }
    
        public int Purch_Retern_ID { get; set; }
        public System.DateTime Addation_Date { get; set; }
        public string Cus_Sup_Mobile { get; set; }
        public decimal Purch_Retern_Total { get; set; }
        public decimal Purch_Retern_Pauid { get; set; }
        public Nullable<decimal> Purch_Retern_Remin { get; set; }
        public string Notes { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Deleted { get; set; }
    
        public virtual Cus_Sup_Table Cus_Sup_Table { get; set; }
        public virtual ICollection<Payback_Purch_Retern_Table> Payback_Purch_Retern_Table { get; set; }
        public virtual ICollection<Purch_Retern_Details_Table> Purch_Retern_Details_Table { get; set; }
    }
}
