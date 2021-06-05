using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contracts.MainCategory;

namespace ShopManagement.Domain.MainCategoryAgg
{
    public interface IMainCategoryRepository : IRepository<long, MainCategory>
    {
        EditMainCategory GetDetails(long id);
        List<MainCategoryViewModel> Search(MainCategorySearchModel searchModel);
    }
}