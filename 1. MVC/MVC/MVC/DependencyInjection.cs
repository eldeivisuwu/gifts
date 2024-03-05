using Microsoft.EntityFrameworkCore;
using MVC.Data.Context;

namespace MVC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration) 
        {
           
            services.AddDbContext<PvContext>(opt => 
            {
                opt.UseSqlServer(configuration.GetConnectionString("PvConnection"));
            }
                );


            return services;
        }
    }
}
