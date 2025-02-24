namespace Ecommerce.Business.Models
{
    public class Product : BaseEntity
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}
