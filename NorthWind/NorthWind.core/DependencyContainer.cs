﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.ConsoleApp.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServices(
            this IServiceCollection services)
        {
            services.AddSingleton<IAppLogger, AppLogger>();
            services.AddSingleton<IProductService, ProductService>();
            return services;
        }
    }
}
