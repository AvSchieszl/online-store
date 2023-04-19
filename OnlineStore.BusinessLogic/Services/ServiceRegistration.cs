using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OnlineStore.DataAccess;
using OnlineStore.DataAccess.Repositories;
using OnlineStore.BusinessLogic.Services;
using Microsoft.Extensions.Logging;

namespace OnlineStore.BusinessLogic
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<StoreContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IUsersService, UserService>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartService, CartService>();

            // Register mapping profiles
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
