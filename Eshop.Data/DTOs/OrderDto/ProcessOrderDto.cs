using Eshop.Data.Entities.OrderEntities;

namespace Eshop.Data.DTOs.OrderDto
{
    public class ProcessOrderDto
    {
        public long OrderId { get; set; }
        public string? PostTraceCode { get; set; }
        public OrderState OrderState { get; set; }
    }
}
