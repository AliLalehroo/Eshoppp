using Eshop.Data.Entities.Common;

namespace Eshop.Data.Entities.ProductEntities
{
    public class Brand : BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageName { get; set; }
        public int Order { get; set; }

        public ICollection<ProductSelectedBrand> ProductSelectedBrands { get; set; }
    }
}
