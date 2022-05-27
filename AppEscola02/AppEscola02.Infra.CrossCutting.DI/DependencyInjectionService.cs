using AppEscola02.Application.AppService;
using AppEscola02.Application.Interfaces;
using AppEscola02.Domain.Interfaces;
using AppEscola02.Domain.Services;
using AppEscola02.Infra.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AppEscola01.Infra.CrossCutting.DI
{
    public class DependencyInjectionService
    {
        public void RegisterDependencyInjection(IConfiguration configuration, IServiceCollection services)
        {
            //RegisterDatabase(configuration, services);
            RegisterApplicationService(services);
            RegisterService(services);
            RegisterRepository(services);
        }
        private void RegisterApplicationService(IServiceCollection services)
        {
            services.AddScoped(typeof(IAlunoAppService), typeof(AlunoAppService));
        }
        private void RegisterService(IServiceCollection services)
        {
            services.AddScoped(typeof(IAlunoService), typeof(AlunoService));
        }
        private void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped(typeof(IAlunoRepository), typeof(AlunoRepository));
        }
    }
}
