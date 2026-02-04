using Microsoft.AspNetCore.Http;

namespace Eshop.Data.DTOs.ProductDto
{
    public class CreateGalleryDto
    {
        public long ProductId { get; set; }
        public IFormFile ImageName { get; set; }
        public int Order { get; set; }
    }
}
