using System.Collections.Generic;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.ProductColor
{
    public interface IProductColorApplication
    {
        OperationResult Create(CreateProductColor command);
        OperationResult Edit(EditProductColor command);
        EditProductColor GetDetails(long id);
        List<ProductColorViewModel> Search(ProductColorSearchModel searchModel);
    }
}