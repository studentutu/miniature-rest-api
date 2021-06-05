using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Weather.Installers
{
    public class Swagger: IInstaller
    {
        public void Install(IConfiguration config, IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo{Title = "Tweetbook", Version = "v1"});
            });
        }
    }
}