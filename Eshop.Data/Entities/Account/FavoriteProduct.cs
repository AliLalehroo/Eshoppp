using Eshop.Data.Entities.Common;
using Eshop.Data.Entities.ProductEntities;

namespace Eshop.Data.Entities.Account
{
    public class FavoriteProduct : BaseEntity
    {
        public long UserId { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
