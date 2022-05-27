using AppExEscola01.Application.AppService;
using AppExEscola01.Application.Interfaces;
using AppExEscola01.Domain.Services;
using AppExEscola01.Infra.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppExEscola01.Infra.CrossCutting.DI
{
    public class DependencyInjectionService
    {
        public void RegisterDependencyInjection(IConfiguration configuration, IServiceCollection services)
        {
            RegisterApplicationService(services);
            RegisterService(services);
            RegisterRepository(services);
        }
        private void RegisterApplicationService(IServiceCollection services)
        {
            //AppExEscola01\AppExEscola01.Application\AppService\AlunoAppService.cs
            //AppExEscola01\AppExEscola01.Application\Interfaces\IAlunoAppService.cs
            services.AddScoped(typeof(IAlunoAppService), typeof(AlunoAppService));
        }
        private void RegisterService(IServiceCollection services)
        {
            //AppExEscola01\AppExEscola01.Domain\Interfaces\IAlunoService.cs
            //AppExEscola01\AppExEscola01.Domain\Services\AlunoService.cs
            services.AddScoped(typeof(IAlunoService), typeof(AlunoService));
        }
        private void RegisterRepository(IServiceCollection services)
        {
            //AppExEscola01\AppExEscola01.Application\Interfaces\IAlunoRepository.cs
            //AppExEscola01\AppExEscola01.Infra.Data\Repository\AlunoRepository.cs
            services.AddScoped(typeof(IAlunoRepository), typeof(AlunoRepository));
        }
    }
}
