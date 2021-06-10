using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductSize;

namespace ShopManagement.Domain.ProductSizeAgg
{
    public interface IProductSizeRepository : IRepository<long, ProductSize>
    {
        EditProductSize GetDetails(long id);
        List<ProductSizeViewModel> Search(ProductSizeSearchModel searchModel);
    }
}