//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        public Material()
        {
            this.FurnitureModel = new HashSet<FurnitureModel>();
        }
    
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    
        public virtual ICollection<FurnitureModel> FurnitureModel { get; set; }
    }
}