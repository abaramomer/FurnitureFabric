using System.Collections.Generic;
using System.Web.Mvc;

namespace Business.ViewModels.FurnitureModel
{
    public class FurnitureAddViewModel
    {
        public FurnitureAddViewModel()
        {
            SelectedMaterials = new List<int>();
        }

        public string Name { get; set; }

        public MultiSelectList Materials { get; set; }

        public SelectList Rooms { get; set; }

        public SelectList Types { get; set; }

        public List<int> SelectedMaterials { get; set; }

        public int SelectedType { get; set; }

        public int SelectedRoom { get; set; }

        public string AdditionalInfo { get; set; }
    }
}