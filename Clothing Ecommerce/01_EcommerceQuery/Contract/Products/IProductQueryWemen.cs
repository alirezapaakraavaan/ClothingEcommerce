﻿using System.Collections.Generic;

namespace _01_EcommerceQuery.Contract.Products
{
    public interface IProductQueryWemen
    {
        List<ProductQueryModel> GetProductsForWemen();
        List<ProductQueryModel> GetWemenMantos();
        List<ProductQueryModel> GetWemenBoluz();
        List<ProductQueryModel> GetWemenTshirt();
        List<ProductQueryModel> GetWemenTrouser();
        List<ProductQueryModel> GetWemenUnderwear();
    }
}