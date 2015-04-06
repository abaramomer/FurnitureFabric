using Business.ViewModels.ProductModels;
using Domain;

namespace Business.Mappings
{
    public static class ProductMappings
    {
        public static ProductListItemViewModel MapProductListToProductListItemViewModel(Product product)
        {
            return new ProductListItemViewModel
            {
                SerialNumber = product.SerialNumber,
                AssemblyDate = product.AssemblyDate,
                Status = product.ProductStatus.Status
            };
        }
    }
}