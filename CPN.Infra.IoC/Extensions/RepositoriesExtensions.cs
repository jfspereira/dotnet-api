using CPN.Infra.Data.Interfaces;
using CPN.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPN.Infra.IoC.Extensions
{
    internal static class RepositoriesExtensions
    {
        public static void AddCPNRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
