using System.Collections.Generic;
using FurnitureFabric.Properties;

namespace FurnitureFabric.ClientViewModels
{
    public class WarehouseMenuViewModel
    {
        public Dictionary<string, string> Items { get; set; }

        public WarehouseMenuViewModel()
        {
            Items = new Dictionary<string, string>
            {
                { "Add Product", "/AddProduct"},
                { "Add Model", "/AddFurnitureModel"},
                { "Model List", "/ModelList"},
            };
        }
    }
}