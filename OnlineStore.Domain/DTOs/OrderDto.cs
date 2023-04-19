namespace OnlineStore.Domain.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int ClerkId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
