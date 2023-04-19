namespace OnlineStore.Domain.Entities;
public class Order : BaseEntity
{
    public int ClerkId { get; set; }
    public virtual User Clerk { get; set; }
    public int CustomerId { get; set; }
    public virtual User Customer { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
}