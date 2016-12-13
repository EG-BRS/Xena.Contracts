using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class OrderWithTotalArticleQuantityDto
    {
        public OrderDto Order { get; set; }
        public decimal TotalQuantity { get; set; }
        public string ContextType { get; set; }
        public long ArticleId { get; set; }
        public bool IsConfirmed { get; set; }
        public long? Id { get; set; }
    }
}