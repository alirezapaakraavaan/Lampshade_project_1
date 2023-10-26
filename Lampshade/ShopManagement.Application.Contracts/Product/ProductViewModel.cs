namespace ShopManagement.Application.Contracts.Product
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Code { get; set; }
        public string Picture { get; set; }
        public string ProductCategoryName { get; set; }
        public long ProductCategoryId { get; set; }
        public string CreationDate { get; set; }
        public bool IsInStock { get; set; }
    }
}