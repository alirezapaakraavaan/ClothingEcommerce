using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.MainCategory;

namespace ShopManagement.Domain.MainCategoryAgg
{
    public interface IMainCategoryRepository : IRepository<long, MainCategory>
    {
        List<MainCategoryViewModel> GetMainCategories();
        EditMainCategory GetDetails(long id);
        List<MainCategoryViewModel> Search(MainCategorySearchModel searchModel);
    }
}