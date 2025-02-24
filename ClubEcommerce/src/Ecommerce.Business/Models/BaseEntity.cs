namespace Ecommerce.Business.Models
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        protected Guid Id { get; set; }
    }
}
