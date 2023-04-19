namespace OnlineStore.Domain.Entities;
public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Thumbnail { get; set; }
    public decimal UnitPrice { get; set; }
    public int CategoryId { get; set; }
    public virtual ProductCategory Category { get; set; }
    public int CreatedById { get; set; }
    public virtual User Creator { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
}