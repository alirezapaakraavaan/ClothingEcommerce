﻿using System.Collections.Generic;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.MainCategory;
using ShopManagement.Domain.MainCategoryAgg;

namespace ShopManagement.Application
{
    public class MainCategoryApplication : IMainCategoryApplication
    {
        private readonly IMainCategoryRepository _mainCategoryRepository;

        public MainCategoryApplication(IMainCategoryRepository mainCategoryRepository)
        {
            _mainCategoryRepository = mainCategoryRepository;
        }

        public OperationResult Create(CreateMainCategory command)
        {
            var operation = new OperationResult();

            var slug = command.Slug.Slugify();
            var mainCategory = new MainCategory(command.Name, command.Picture, command.PictureAlt, command.PictureTitle,
                command.Keywords, command.MetaDescription, slug);

            _mainCategoryRepository.Create(mainCategory);
            _mainCategoryRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditMainCategory command)
        {
            var operation = new OperationResult();
            var mainCategory = _mainCategoryRepository.Get(command.Id);
            if (mainCategory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_mainCategoryRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            mainCategory.Edit(command.Name, command.Picture, command.PictureAlt, command.PictureTitle,
                command.Keywords, command.MetaDescription, slug);

            _mainCategoryRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var mainCategory = _mainCategoryRepository.Get(id);
            if (mainCategory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            mainCategory.Remove();
            _mainCategoryRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var mainCategory = _mainCategoryRepository.Get(id);
            if (mainCategory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            mainCategory.Restore();
            _mainCategoryRepository.SaveChanges();
            return operation.Succeeded();
        }

        public EditMainCategory GetDetails(long id)
        {
            return _mainCategoryRepository.GetDetails(id);
        }

        public List<MainCategoryViewModel> Search(MainCategorySearchModel searchModel)
        {
            return _mainCategoryRepository.Search(searchModel);
        }
    }
}