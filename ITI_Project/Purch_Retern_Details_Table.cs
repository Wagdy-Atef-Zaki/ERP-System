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
    
    public partial class Purch_Retern_Details_Table
    {
        public int Purch_Retern_Details_ID { get; set; }
        public int Purch_Retern_ID { get; set; }
        public int Product_ID { get; set; }
        public Nullable<System.DateTime> Expire_Date { get; set; }
        public string ExpireOrNot { get; set; }
        public int Quantity { get; set; }
        public decimal Purch_Price { get; set; }
        public Nullable<decimal> User_Price { get; set; }
        public decimal Dealer_Price { get; set; }
        public decimal Purch_Total { get; set; }
        public Nullable<int> Deleted { get; set; }
    
        public virtual Purch_Retern_Table Purch_Retern_Table { get; set; }
    }
}