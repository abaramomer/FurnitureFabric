using System;

namespace Business.ViewModels.ProductModels
{
    public class ProductListItemViewModel
    {
        public string SerialNumber { get; set; }

        public string Status { get; set; }

        public DateTime AssemblyDate { get; set; }
    }
}