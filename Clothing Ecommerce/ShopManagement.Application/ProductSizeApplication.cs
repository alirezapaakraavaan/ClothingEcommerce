using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductSize;
using ShopManagement.Domain.ProductSizeAgg;

namespace ShopManagement.Application
{
    public class ProductSizeApplication : IProductSizeApplication
    {
        private readonly IProductSizeRepository _productSizeRepository;

        public ProductSizeApplication(IProductSizeRepository productSizeRepository)
        {
            _productSizeRepository = productSizeRepository;
        }

        public OperationResult Create(CreateProductSize command)
        {
            var operation = new OperationResult();
            if (_productSizeRepository.Exists(x => x.Size == command.Size))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var productSize = new ProductSize(command.Size, command.ProductId);
            _productSizeRepository.Create(productSize);
            _productSizeRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProductSize command)
        {
            var operation = new OperationResult();
            var productSize = _productSizeRepository.Get(command.Id);
            if (productSize == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_productSizeRepository.Exists(x => x.Size == command.Size && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            productSize.Edit(command.Size, command.ProductId);
            _productSizeRepository.SaveChanges();
            return operation.Succeeded();
        }

        public EditProductSize GetDetails(long id)
        {
            return _productSizeRepository.GetDetails(id);
        }

        public List<ProductSizeViewModel> Search(ProductSizeSearchModel searchModel)
        {
            return _productSizeRepository.Search(searchModel);
        }
    }
}