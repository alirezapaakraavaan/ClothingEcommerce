using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.MainCategory;
using ShopManagement.Domain.MainCategoryAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class MainCategoryRepository : RepositoryBase<long, MainCategory>, IMainCategoryRepository
    {
        private readonly ShopContext _context;

        public MainCategoryRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditMainCategory GetDetails(long id)
        {
            return _context.MainCategories.Where(x => !x.IsRemoved).Select(x => new EditMainCategory
            {
                Id = x.Id,
                Name = x.Name,
                Slug = x.Slug,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<MainCategoryViewModel> Search(MainCategorySearchModel searchModel)
        {
            var query = _context.MainCategories.Where(x => !x.IsRemoved).Select(x => new MainCategoryViewModel
            {
                Id = x.Id,
                CreationDate = x.CreationDate.ToFarsi(),
                Name = x.Name,
                Picture = x.Picture,
                IsRemoved = x.IsRemoved
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}