using Microsoft.Extensions.DependencyInjection;
using MyProjectR_B.Repositories.Interfaces;
using MyProjectR_B.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectR_B.Repositories
{
    public static class Extentions
    {
        public static IServiceCollection AddRepositoriesInjections(this IServiceCollection services)
        {
            services.AddScoped<IChildrenRepository, ChildrenRepository>();
            //services.AddScoped<IFontSizeRepository, FontSizeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
