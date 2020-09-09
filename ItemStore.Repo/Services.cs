using ItemStore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItemStore.Repo
{
    public class Services
    {
        public static IServiceCollection addservice (string connection , IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<ItemDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(connection), b => b.MigrationsAssembly("ItemStore.UI")));
            return services;
        }
    }
}
