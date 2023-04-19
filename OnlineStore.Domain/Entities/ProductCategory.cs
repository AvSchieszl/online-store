namespace OnlineStore.Domain.Entities;
public class ProductCategory : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public bool IsDeleted { get; set; }
}