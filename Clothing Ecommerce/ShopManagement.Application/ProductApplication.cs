using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository, IFileUploader fileUploader,
            IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _fileUploader = fileUploader;
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();

            var slug = command.Slug.Slugify();
            var categorySlug = _productCategoryRepository.GetSlugBy(command.ProductCategoryId);
            var picturePath = $"{command.Slug}//{slug}";
            var pictureName = _fileUploader.Upload(command.Picture, picturePath);
            var product = new Product(command.Name, command.Code, command.ShortDescription,
                command.Description, pictureName, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.ProductCategoryId);

            _productRepository.Create(product);
            _productRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.GetProductWithCategory(command.Id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var slug = command.Slug.Slugify();
            var picturePath = $"{product.ProductCategory.Slug}//{slug}";
            var pictureName = _fileUploader.Upload(command.Picture, picturePath);
            product.Edit(command.Name, command.Code, command.ShortDescription,
                command.Description, pictureName, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.ProductCategoryId);

            _productRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);

            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            product.Remove();
            _productRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);

            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            product.Restore();
            _productRepository.SaveChanges();
            return operation.Succeeded();
        }

        public EditProduct GetDetails(long id)
        {
            return _productRepository.GetDetails(id);
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            return _productRepository.Search(searchModel);
        }

        public List<ProductViewModel> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}