using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductSize;

namespace ShopManagement.Application.Contracts.Product
{
    public interface IProductApplication
    {
        OperationResult Create(CreateProduct command);
        OperationResult Edit(EditProduct command);
        OperationResult InStock(long id);
        OperationResult NotInStock(long id);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditProduct GetDetails(long id);
        List<ProductViewModel> Search(ProductSearchModel searchModel);
        List<ProductViewModel> GetProducts();
        List<ProductSizeViewModel> GetProductSizes();
    }
}