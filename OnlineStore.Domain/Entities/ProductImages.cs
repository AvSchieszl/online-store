namespace OnlineStore.Domain.Entities;
public class ProductImage : BaseEntity
{
    public int Order { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
    public string Path { get; set; }
}