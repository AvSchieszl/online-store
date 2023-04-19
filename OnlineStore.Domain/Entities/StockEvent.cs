using OnlineStore.Domain.Enums;

namespace OnlineStore.Domain.Entities
{
    public class StockEvent : BaseEntity
    {
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public StockType Type { get; set; }
        public string Reason { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
