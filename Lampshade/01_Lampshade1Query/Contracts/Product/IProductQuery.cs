using System.Collections.Generic;

namespace _01_Lampshade1Query.Contracts.Product
{
    public interface IProductQuery
    {
        List<ProductQueryModel> GetLatestArrivals();
    }
}