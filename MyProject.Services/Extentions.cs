using Microsoft.Extensions.DependencyInjection;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Net.Http;

namespace MyProject.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddServicesInjections (this IServiceCollection services)
        {
          
            services.AddScoped<IRandNumber,RandNumberService>();

            services.AddHttpClient<IForecastService, ForcastService>();

            return services;
        }
    }
}
