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
    
    public partial class Order_Details_Table
    {
        public int Order_Details_ID { get; set; }
        public int Order_ID { get; set; }
        public int product_ID { get; set; }
        public int Quantity { get; set; }
        public decimal product_Price { get; set; }
        public decimal Total { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> Deleted { get; set; }
    
        public virtual Order_Table Order_Table { get; set; }
        public virtual Product_Table Product_Table { get; set; }
    }
}
