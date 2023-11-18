﻿using System.Collections.Generic;

namespace _01_Lampshade1Query.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetProductCategories();
        List<ProductCategoryQueryModel> GetProductCategoriesWithProducts();
        ProductCategoryQueryModel GetProductCategoryWithProductsBy(string slug);
    }
}