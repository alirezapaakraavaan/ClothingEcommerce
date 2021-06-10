using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductPrice;
using ShopManagement.Domain.ProductPriceAgg;

namespace ShopManagement.Application
{
    public class ProductPriceApplication : IProductPriceApplication
    {
        private readonly IProductPriceRepository _productPriceRepository;

        public ProductPriceApplication(IProductPriceRepository productPriceRepository)
        {
            _productPriceRepository = productPriceRepository;
        }

        public OperationResult Create(CreateProductPrice command)
        {
            var operation = new OperationResult();
            var productPrice = new ProductPrice(command.Price, command.ProductId, command.ProductSizeId);
            _productPriceRepository.Create(productPrice);
            _productPriceRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProductPrice command)
        {
            var operation = new OperationResult();
            var productPrice = _productPriceRepository.Get(command.Id);
            productPrice.Edit(command.Price, command.ProductId, command.ProductSizeId);
            _productPriceRepository.SaveChanges();
            return operation.Succeeded();
        }

        public EditProductPrice GetDetails(long id)
        {
            return _productPriceRepository.GetDetails(id);
        }

        public List<ProductPriceViewModel> Search(ProductPriceSearchModel searchModel)
        {
            return _productPriceRepository.Search(searchModel);
        }
    }
}