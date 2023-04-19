namespace OnlineStore.Domain.Entities;
public class OrderDetails : BaseEntity
{
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}