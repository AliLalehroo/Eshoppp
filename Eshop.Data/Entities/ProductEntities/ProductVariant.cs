using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.ProductEntities
{
    public class ProductVariant : BaseEntity
    {
        public long ProductId { get; set; }
        public long ColorId { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
        public string ColorTitle { get; set; }
        public string ColorCode { get; set; }
        public Product Product { get; set; }
    }
}
