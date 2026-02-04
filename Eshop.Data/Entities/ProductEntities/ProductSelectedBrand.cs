using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.ProductEntities
{
    public class ProductSelectedBrand : BaseEntity
    {
        public long ProductId { get; set; }
        public long BrandId { get; set; }
        public Product Product { get; set; }
        public Brand Brand { get; set; }
    }
}
