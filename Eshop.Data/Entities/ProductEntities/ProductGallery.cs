using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.ProductEntities
{
    public class ProductGallery : BaseEntity
    {
        public long ProductId { get; set; }
        public string ImageName { get; set; }
        public int Order { get; set; }
    }
}
