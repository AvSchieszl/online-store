using AutoMapper;
using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Helpers;

namespace OnlineStore.Domain.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(d => d.CategoryId, o => o.MapFrom(s => s.Category.Id))
                .ForMember(d => d.CategoryName, o => o.MapFrom(s => s.Category.Name))
                .ForMember(d => d.Creator, o => o.MapFrom(s => $"{s.Creator.Role}: {s.Creator.FirstName} {s.Creator.LastName}"))
                .ForMember(d => d.Thumbnail, o => o.MapFrom<ProductUrlResolver>());

            // Add reverse mapping from ProductDto to Product for Updating
            CreateMap<ProductDto, Product>()
                .ForMember(d => d.CategoryId, o => o.MapFrom(s => s.CategoryId))
                .ForMember(d => d.Creator, o => o.Ignore()) // Ignore the Creator field
                .ForMember(d => d.CreatedAt, o => o.Ignore()); // Ignore the CreatedAt field when updating

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<StockEvent, StockEventDto>();
            CreateMap<StockEventDto, StockEvent>();

            CreateMap<Stock, StockDto>();
            CreateMap<StockDto, Stock>();

            CreateMap<ProductImage, ProductImageDto>();
            CreateMap<ProductImageDto, ProductImage>();

            CreateMap<ProductCategory, ProductCategoryDto>();
            CreateMap<ProductCategoryDto, ProductCategory>();

            CreateMap<OrderDetails, OrderDetailsDto>();
            CreateMap<OrderDetailsDto, OrderDetails>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
        }
    }
}