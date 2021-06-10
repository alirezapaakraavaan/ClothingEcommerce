using System.Collections.Generic;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.ProductPrice
{
    public interface IProductPriceApplication
    {
        OperationResult Create(CreateProductPrice command);
        OperationResult Edit(EditProductPrice command);
        EditProductPrice GetDetails(long id);
        List<ProductPriceViewModel> Search(ProductPriceSearchModel searchModel);
    }
}