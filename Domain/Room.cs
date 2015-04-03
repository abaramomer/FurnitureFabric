//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    [Table("Room")]
    public partial class Room : Entity
    {
        public Room()
        {
            this.FurnitureModels = new HashSet<FurnitureModel>();
        }
    
        [Key]
        public int RoomId { get; set; }

        [Column("Room")]
        public string RoomName { get; set; }
    
        public virtual ICollection<FurnitureModel> FurnitureModels { get; set; }
    }
}
