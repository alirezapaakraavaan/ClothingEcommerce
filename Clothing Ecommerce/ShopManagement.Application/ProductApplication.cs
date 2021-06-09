﻿using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public OperationResult Create(CreateProduct command)
        {
            var operation = new OperationResult();

            var slug = command.Slug.Slugify();
            var product = new Product(command.Name, command.Code, command.UnitPrice, command.ShortDescription,
                command.Description, command.Picture, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.Color, command.Size, command.ProductCategoryId);

            _productRepository.Create(product);
            _productRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProduct command)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(command.Id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_productRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            product.Edit(command.Name, command.Code, command.UnitPrice, command.ShortDescription,
                command.Description, command.Picture, command.PictureAlt, command.PictureTitle, slug,
                command.Keywords, command.MetaDescription, command.Color, command.Size, command.ProductCategoryId);

            _productRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult InStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);

            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            product.InStock();
            _productRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult NotInStock(long id)
        {
            var operation = new OperationResult();
            var product = _productRepository.Get(id);

            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            product.NotInStock();
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
    }
}