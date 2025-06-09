using Saas.Dto.OrderItemDto;

namespace Saas.Dto.OrderDto
{
    public class OrderCreateDto{
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; } = "Pendente";
        public int? OrderPaymentId { get; set; }
        public int TenantId { get; set; }
        public ICollection<OrderItemCreateDto> OrderItems { get; set; } = new List<OrderItemCreateDto>();

    }
}
