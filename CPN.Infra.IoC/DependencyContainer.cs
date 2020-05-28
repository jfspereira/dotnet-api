using CPN.Infra.IoC.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CPN.Infra.IoC
{
   public static class DependencyContainer
    {
        public static void AddCPNObjectsScope(this IServiceCollection services)
        {
            //Add Services
            services.AddCPNServices();

            //Add Repositories
            services.AddCPNRepositories();

        }
    }
}
