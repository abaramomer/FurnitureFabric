//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductStatus
    {
        public ProductStatus()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int StatusId { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}
