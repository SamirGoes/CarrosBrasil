using System;
using CarrosBrasil.Infra.Data.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CarrosBrasil.Infra.Data
{
    public static class Configurations
    {
        public static void ConfigureMongo(this IServiceCollection services)
        {
            services.Configure<FrotaMinicipioSettings>(Configurations.GetSection(nameof(FrotaMinicipioSettings)));

            services.AddSingleton<IFrotaMinicipioSettings>(sp => sp.GetRequiredService<IOptions<FrotaMinicipioSettings>>().Value);
        }
    }
}
