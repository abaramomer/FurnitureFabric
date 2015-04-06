using System.Collections.Generic;
using FurnitureFabric.Properties;

namespace FurnitureFabric.ClientViewModels
{
    public class MainMenuViewModel
    {
        public Dictionary<string, string> Items { get; set; }

        public MainMenuViewModel()
        {
            Items = new Dictionary<string, string>
            {
                { Resources.MainMenu_ModelList, "/Client"},
                { Resources.MainMenu_Warehouse, "/Warehouse"},
                { Resources.MainMenu_Import, "/Import"},
                { Resources.MainMenu_Reports, "/Report"},
            };
        }
    }
}