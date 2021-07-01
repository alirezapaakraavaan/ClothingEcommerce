using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProducts, "ListProducts"),
                        new PermissionDto(ShopPermissions.SearchProducts, "SearchProducts"),
                        new PermissionDto(ShopPermissions.CreateProducts, "CreateProducts"),
                        new PermissionDto(ShopPermissions.EditProducts, "EditProducts"),
                        new PermissionDto(ShopPermissions.RemoveProducts, "RemoveProducts")
                    }
                },
                {
                    "ProductCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchProductCategories, "SearchProductCategories"),
                        new PermissionDto(ShopPermissions.ListProductCategories, "ListProductCategories"),
                        new PermissionDto(ShopPermissions.CreateProductCategories, "CreateProductCategories"),
                        new PermissionDto(ShopPermissions.EditProductCategories, "EditProductCategories"),
                        new PermissionDto(ShopPermissions.RemoveProductCategories, "RemoveProductCategories")
                    }
                },
                {
                    "MainCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.SearchMainCategories, "SearchMainCategories"),
                        new PermissionDto(ShopPermissions.ListMainCategories, "ListMainCategories"),
                        new PermissionDto(ShopPermissions.CreateMainCategories, "CreateMainCategories"),
                        new PermissionDto(ShopPermissions.EditMainCategories, "EditMainCategories"),
                        new PermissionDto(ShopPermissions.RemoveMainCategories, "RemoveMainCategories")
                    }
                }
            };
        }
    }
}