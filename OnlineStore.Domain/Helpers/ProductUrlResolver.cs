using AutoMapper;
using Microsoft.Extensions.Configuration;
using OnlineStore.Domain.DTOs;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductDto, string>
    {
        private readonly IConfiguration _config;

        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product source, ProductDto destination, string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.Thumbnail))
            {
                return _config["ApiUrl"] + source.Thumbnail; //TODO: When adding photos to project add 'ApiUrl' to appsettings
            }

            return null;
        }
    }
}
