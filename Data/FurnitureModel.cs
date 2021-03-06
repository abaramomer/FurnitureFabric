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
    
    public partial class FurnitureModel
    {
        public FurnitureModel()
        {
            this.Product = new HashSet<Product>();
            this.Color = new HashSet<Color>();
            this.Material = new HashSet<Material>();
        }
    
        public int FurnitureModelId { get; set; }
        public string Name { get; set; }
        public string AdditionalInfo { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> RoomId { get; set; }
    
        public virtual FurnitureType FurnitureType { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Color> Color { get; set; }
        public virtual ICollection<Material> Material { get; set; }
    }
}
