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
    
    public partial class Unite_Table
    {
        public Unite_Table()
        {
            this.Product_Table = new HashSet<Product_Table>();
        }
    
        public int Unite_ID { get; set; }
        public string Unite_Name { get; set; }
        public string Unite_Description { get; set; }
        public Nullable<int> Deleted { get; set; }
    
        public virtual ICollection<Product_Table> Product_Table { get; set; }
    }
}
