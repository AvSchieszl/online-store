using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineStore.DataAccess.SeedData
{
    internal class SeedDataClass
    {
        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            // Seed User
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Anthony",
                    LastName = "von Schieszl",
                    CivilianId = "123abc",
                    Email = "admin@example.com",
                    Password = "123",
                    PhoneNumber = "12345678",
                    DateOfBirth = DateTime.Parse("11/11/1998"),
                    Role = UserRole.Admin,
                    IsDeleted = false
                },
                new User
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "B.",
                    CivilianId = "123cba",
                    Email = "clerk@example.com",
                    Password = "123",
                    PhoneNumber = "22345678",
                    DateOfBirth = DateTime.Parse("05/08/1993"),
                    Role = UserRole.Clerk,
                    IsDeleted = false
                },
                new User
                {
                    Id = 3,
                    FirstName = "Carol",
                    LastName = "C.",
                    CivilianId = "321abc",
                    Email = "customer@example.com",
                    Password = "123",
                    PhoneNumber = "32345678",
                    DateOfBirth = DateTime.Parse("04/03/1987"),
                    Role = UserRole.Customer,
                    IsDeleted = false
                }
            );

            // Seed ProductCategory
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    Id = 1,
                    Name = "Camera",
                    Description = "Camera equipment",
                    Image = "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80",
                    IsDeleted = false
                },
                new ProductCategory
                {
                    Id = 2,
                    Name = "Footwear",
                    Description = "Shoes",
                    Image = "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80",
                    IsDeleted = false
                }
                );

            // Seed Products
            for (int i = 1; i <= 25; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        Name = $"Camera Product {i}",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Thumbnail = "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80",
                        UnitPrice = (decimal)(new Random().NextDouble() * (250 - 15) + 15),
                        CategoryId = 1,
                        CreatedById = 2,
                        CreatedAt = DateTime.Now,
                        IsDeleted = false
                    },
                    new Product
                    {
                        Id = i + 25,
                        Name = $"Shoe {i}",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Thumbnail = "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80",
                        UnitPrice = (decimal)(new Random().NextDouble() * (250 - 15) + 15),
                        CategoryId = 2,
                        CreatedById = 2,
                        CreatedAt = DateTime.Now,
                        IsDeleted = false
                    }
                );
            }
            // Seed ProductImages, TODO change to images stored on DB
            for (int i = 1; i <= 25; i++)
            {
                modelBuilder.Entity<ProductImage>().HasData(
                    new ProductImage
                    {
                        Id = i,
                        Order = 1,
                        ProductId = i,
                        Path = "https://images.unsplash.com/photo-1526170375885-4d8ecf77b99f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
                    },
                    new ProductImage
                    {
                        Id = i + 25,
                        Order = 1,
                        ProductId = i + 25,
                        Path = "https://images.unsplash.com/photo-1560769629-975ec94e6a86?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80"
                    }
                );
            }

            // Seed Stocks
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Stock>().HasData(
                    new Stock
                    {
                        Id = i,
                        ProductId = i,
                        Quantity = new Random().Next(1, 100)
                    }
                );
            }

            // Seed StockEvents
            modelBuilder.Entity<StockEvent>().HasData(
                new StockEvent
                {
                    Id = 1,
                    StockId = 1,
                    Type = StockType.In,
                    Reason = "Initial stock",
                    Quantity = 50,
                    CreatedAt = DateTime.Now
                },
                new StockEvent
                {
                    Id = 2,
                    StockId = 2,
                    Type = StockType.In,
                    Reason = "Restock",
                    Quantity = 30,
                    CreatedAt = DateTime.Now
                }
            );

            // Seed Orders
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    ClerkId = 2,
                    CustomerId = 3,
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                }
            );

            // Seed OrderDetails
            modelBuilder.Entity<OrderDetails>().HasData(
                new OrderDetails
                {
                    Id = 1,
                    OrderId = 1,
                    ProductId = 1,
                    UnitPrice = 100,
                    Quantity = 2
                },
                new OrderDetails
                {
                    Id = 2,
                    OrderId = 1,
                    ProductId = 26,
                    UnitPrice = 75,
                    Quantity = 1
                }
            );
        }
    }
}
