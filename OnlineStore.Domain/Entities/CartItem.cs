﻿namespace OnlineStore.Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Picture { get; set; }
        public string Category { get; set; }
    }
}