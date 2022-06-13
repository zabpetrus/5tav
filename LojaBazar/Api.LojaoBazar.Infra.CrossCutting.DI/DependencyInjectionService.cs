using Api.LojaoBazar.Application.AppService;
using Api.LojaoBazar.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace Api.LojaoBazar.Infra.CrossCutting.DI
{
    public class DependencyInjectionService
    {
        public static void RegisterDependencyInjection(IConfiguration configuration, IServiceCollection services)
        {
            //throw new NotImplementedException();
            if(configuration == null)
            {
                RegisterApplicationService(services);
            }
            

        }

        private static void RegisterApplicationService(IServiceCollection services)
        {
            services.AddScoped(typeof(IClienteAppService), typeof(ClienteAppService));
        }
    }
}
