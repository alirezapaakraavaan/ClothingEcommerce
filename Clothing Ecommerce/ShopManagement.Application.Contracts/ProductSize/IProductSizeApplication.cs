using System.Collections.Generic;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.ProductSize
{
    public interface IProductSizeApplication
    {
        OperationResult Create(CreateProductSize command);
        OperationResult Edit(EditProductSize command);
        EditProductSize GetDetails(long id);
        List<ProductSizeViewModel> Search(ProductSizeSearchModel searchModel);
    }
}