using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductColor;
using ShopManagement.Domain.ProductColorAgg;

namespace ShopManagement.Application
{
    public class ProductColorApplication : IProductColorApplication
    {
        private readonly IProductColorRepository _productColorRepository;

        public ProductColorApplication(IProductColorRepository productColorRepository)
        {
            _productColorRepository = productColorRepository;
        }

        public OperationResult Create(CreateProductColor command)
        {
            var operation = new OperationResult();

            var productColor = new ProductColor(command.Color, command.ProductSizeId, command.ProductId);
            _productColorRepository.Create(productColor);
            _productColorRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProductColor command)
        {
            var operation = new OperationResult();
            var productColor = _productColorRepository.Get(command.Id);
            if (productColor == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            productColor.Edit(command.Color, command.ProductSizeId, command.ProductId);
            _productColorRepository.SaveChanges();
            return operation.Succeeded();
        }

        public EditProductColor GetDetails(long id)
        {
            return _productColorRepository.GetDetails(id);
        }

        public List<ProductColorViewModel> Search(ProductColorSearchModel searchModel)
        {
            return _productColorRepository.Search(searchModel);
        }
    }
}