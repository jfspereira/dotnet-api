using CPN.Application.Interfaces;
using CPN.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CPN.Infra.IoC.Extensions
{
    internal static class ServiceExtensions
    {
        public static void AddCPNServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
