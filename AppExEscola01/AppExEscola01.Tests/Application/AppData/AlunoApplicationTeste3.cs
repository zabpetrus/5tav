using AppExEscola01.Application.AppService;
using AppExEscola01.Application.Interfaces;
using AppExEscola01.Application.ViewModel;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppExEscola01.Tests.Application.AppData
{
    public class AlunoApplicationTeste3
    {
        [Fact]
        public void AlunoAppServiceTeste1()
        {
            AlunoCreateViewModel alunocreateviewmodel = new AlunoCreateViewModel(                
                "Brutal Bull", //nome
                "pombomail@mail.com", //email
                "176.031.590-75", //cpf
                "21589-555", //cep
                "20/09/2001" //datanascimento
                );
            AlunoResultViewModel alunocreateresultviewmodel = new AlunoResultViewModel(
                 1, //id
                "Brutal Bull", //nome
                "123456", //matricula
                "pombomail@mail.com", //email
                "176.031.590-75", //cpf
                "21589-555", //cep
                "20/09/2001" //datanascimento
                );

            Mock<IAlunoAppService> mock = new Mock<IAlunoAppService>();
            mock.Setup( m => m.Create(alunocreateviewmodel)).Returns(alunocreateresultviewmodel);

            AlunoAppService alunoAppService = new AlunoAppService();
            alunoAppService.setIAlunoAppService(mock.Object);

            var teste = alunoAppService.Create(alunocreateviewmodel);
            Assert.NotNull(teste);
            Assert.NotEqual(alunocreateresultviewmodel, teste);




        }
    }
}
