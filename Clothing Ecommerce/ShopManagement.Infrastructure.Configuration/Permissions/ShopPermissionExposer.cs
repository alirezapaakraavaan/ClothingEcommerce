﻿using System.Collections.Generic;
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
                        new PermissionDto(10, "ListProducts"),
                        new PermissionDto(11, "SearchProducts"),
                        new PermissionDto(12, "CreateProducts"),
                        new PermissionDto(13, "EditProducts"),
                        new PermissionDto(14, "RemoveProducts")
                    }
                },
                {
                    "ProductCategory", new List<PermissionDto>
                    {
                        new PermissionDto(20, "SearchProductCategories"),
                        new PermissionDto(21, "ListProductCategories"),
                        new PermissionDto(22, "CreateProductCategories"),
                        new PermissionDto(23, "EditProductCategories"),
                        new PermissionDto(24, "RemoveProductCategories")
                    }
                }
            };
        }
    }
}