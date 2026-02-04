using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.ProductEntities
{
    public class ProductSelectedCategory : BaseEntity
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public Product Product { get; set; }
        public ProductCategory Category { get; set; }
    }
}
