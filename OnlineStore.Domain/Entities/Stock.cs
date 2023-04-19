namespace OnlineStore.Domain.Entities
{
    public class Stock : BaseEntity
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
