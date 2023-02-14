using Microsoft.Extensions.DependencyInjection;
using MyProjectR_B.Repositories;
using MyProjectR_B.Servises.Interfaces;
using MyProjectR_B.Servises.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace MyProjectR_B.Servises
{
    public static class Extentions
    {
        public static IServiceCollection AddServicesInjections(this IServiceCollection services)
        {

            services.AddRepositoriesInjections();
            services.AddScoped< IUserService, UserService >();
            //services.AddScoped< IFontSizeService, FontSizeService>();
            services.AddScoped< IChildrenService, ChildrenService>();


            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
