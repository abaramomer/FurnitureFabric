using System.Collections.Generic;

namespace Business.ViewModels.ProductModels
{
    public class ProductGridViewModel
    {
        public ProductGridViewModel()
        {
            ListItems = new List<ProductListItemViewModel>();    
        }

        public List<ProductListItemViewModel> ListItems { get; set; }

        public ProductFilterViewModel FilterViewModel { get; set; }
    }
}