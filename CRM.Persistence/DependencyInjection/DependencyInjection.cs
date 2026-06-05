using CRM.Application.Common.Interfaces;
using CRM.Persistence.Context;
using CRM.Persistence.Repositories;
using CRM.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRM.Persistence.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<ICustomerRepository,
                CustomerRepository>();

            services.AddScoped<IUnitOfWork,
                UnitOfWork>();

            return services;
        }
    }
}
