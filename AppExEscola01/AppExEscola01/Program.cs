using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AppExEscola01
{
    public class Program
    {
        /*
         * System.AggregateException: 'Some services are not able to be constructed 
         * (Error while validating the service descriptor 
         * 'ServiceType: AppExEscola01.Application.Interfaces.IAlunoAppService Lifetime: 
         * Scoped ImplementationType: AppExEscola01.Application.AppService.AlunoAppService': 
         * A circular dependency was detected for the service of type 'AppExEscola01.Application.Interfaces.IAlunoAppService'.
         * AppExEscola01.Application.Interfaces.IAlunoAppService(AppExEscola01.Application.AppService.AlunoAppService) ->
         * AppExEscola01.Application.Interfaces.IAlunoAppService)'
         * */
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
