namespace Ecommerce.Business.Models
{
    public class ProductImage : BaseEntity
    {
        public string Url { get; set; }
        public string AltText { get; set; }
        public bool IsPrimary { get; set; }

        //Relation class Product
        public string ProductSku { get; set; }
        public Product Product { get; set; }
    }
}
