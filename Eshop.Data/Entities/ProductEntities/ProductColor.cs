using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.ProductEntities
{
    public class ProductColor : BaseEntity
    {
        public string Title { get; set; }
        public string ColorCode { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
