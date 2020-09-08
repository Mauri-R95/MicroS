using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MicroS.Infrastructure.DataAccess.Contracts.Repositories;
using MicroS.Infrastructure.DataAccess.Repositories;

namespace MicroS.Infrastructure
{
    public static class IoCRegister{
        //Inyection of Control
        // Inyector de dependencias
        //metodos para registrar todos los servicios y reñositorios
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);

            return services;
        }
        public static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            //services.AddTransient<IUserService, UserService>();
            //services.AddTransient<IUserService, UserService>();
            return services;

        }
        public static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {
            //La implementacion del servicio es en base a la interfaz
            services.AddTransient<IRegionRepository, RegionRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IComunaRepository, ComunaRepository>();
            return services;

        }
    }
}
