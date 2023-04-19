using OnlineStore.Domain.Enums;

public class StockEventDto
{
    public int Id { get; set; }
    public int StockId { get; set; }
    public StockType Type { get; set; }
    public string Reason { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }
}
