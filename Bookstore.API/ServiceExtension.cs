using Bookstore.Application;
using Bookstore.Infrastructure.Persistence;

namespace Bookstore.API
{
    public static class ServiceExtension
    { 
            public static IServiceCollection AddApplicationServices(this IServiceCollection services)
            {
                //services.AddAutoMapper(Assembly.GetExecutingAssembly()); 
                services.AddAutoMapper(typeof(Program).Assembly);
                services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
                return services;
            }

            public static IServiceCollection AddRepositories(this IServiceCollection services)
            {
                services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                return services;
            }
        
    }
}
