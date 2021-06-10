using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductColor;

namespace ShopManagement.Domain.ProductColorAgg
{
    public interface IProductColorRepository : IRepository<long, ProductColor>
    {
        EditProductColor GetDetails(long id);
        List<ProductColorViewModel> Search(ProductColorSearchModel searchModel);
    }
}