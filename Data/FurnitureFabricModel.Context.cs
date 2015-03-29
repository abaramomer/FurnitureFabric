﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using Domain;
    
    public partial class FurnitureFabricEntities : DbContext
    {
        public FurnitureFabricEntities()
            : base("name=FurnitureFabricEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Color> Color { get; set; }
        public DbSet<FurnitureModel> FurnitureModel { get; set; }
        public DbSet<FurnitureType> FurnitureType { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductStatus> ProductStatus { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
    
        public virtual int AddProductToWarehouse(Nullable<int> furnitureModelId, Nullable<System.DateTime> assemblyDate)
        {
            var furnitureModelIdParameter = furnitureModelId.HasValue ?
                new ObjectParameter("FurnitureModelId", furnitureModelId) :
                new ObjectParameter("FurnitureModelId", typeof(int));
    
            var assemblyDateParameter = assemblyDate.HasValue ?
                new ObjectParameter("AssemblyDate", assemblyDate) :
                new ObjectParameter("AssemblyDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddProductToWarehouse", furnitureModelIdParameter, assemblyDateParameter);
        }
    
        public virtual ObjectResult<string> GetUniqueSerialNumber()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetUniqueSerialNumber");
        }
    
        public virtual int SaleProduct(Nullable<int> productId, Nullable<double> cost, Nullable<System.DateTime> saleDate)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("Cost", cost) :
                new ObjectParameter("Cost", typeof(double));
    
            var saleDateParameter = saleDate.HasValue ?
                new ObjectParameter("SaleDate", saleDate) :
                new ObjectParameter("SaleDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SaleProduct", productIdParameter, costParameter, saleDateParameter);
        }
    }
}
