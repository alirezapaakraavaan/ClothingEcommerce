using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductPrice;

namespace ShopManagement.Domain.ProductPriceAgg
{
    public interface IProductPriceRepository : IRepository<long, ProductPrice>
    {
        EditProductPrice GetDetails(long id);
        List<ProductPriceViewModel> Search(ProductPriceSearchModel searchModel);
    }
}