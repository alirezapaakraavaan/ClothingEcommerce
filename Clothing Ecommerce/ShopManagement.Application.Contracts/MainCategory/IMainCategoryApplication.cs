using System.Collections.Generic;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.MainCategory
{
    public interface IMainCategoryApplication
    {
        OperationResult Create(CreateMainCategory command);
        OperationResult Edit(EditMainCategory command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditMainCategory GetDetails(long id);
        List<MainCategoryViewModel> Search(MainCategorySearchModel searchModel);
    }
}