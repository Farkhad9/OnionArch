using Microsoft.Extensions.DependencyInjection;
using OnionArch.Application.Services.Concretes;
using OnionArch.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArch.Application
{
    public static class ServiceRegistration
    {
        extension(IServiceCollection services)
        {
            public void AddApplicationServices()
            {
                services.AddScoped<ICategoryService, CategoryService>();
            }
        }
    }
}
