using AppExEscola01.Application.AppService;
using AppExEscola01.Application.Interfaces;
using AppExEscola01.Application.ViewModel;
using AppExEscola01.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppExEscola01.Tests.Application
{
    public class AlunoTestes2
    {
        [Fact]
        public void Test1()
        {            

            AlunoResultViewModel alunoResult = new AlunoResultViewModel(
                1,
                "Brutal Bull",
                "123456",
                "pombomail@mail.com",
                "612.547.851-36",
                "21589-555",
                "20/09/2001"               
               );

            alunoResult.SetResultValidation(false);
            Assert.NotNull(alunoResult);           

        }

        [Fact]
        public void Test2()
        {
            //public AlunoCreateViewModel(string nome, string email, string cpf, string cep, string dataNascimento)
            AlunoCreateViewModel alunoCreateViewModel = new AlunoCreateViewModel(
                "Jose", //Nome
                "pombomail@mail.com", //email
                "23658745983", //cpf
                "26875-589", //cep
                "12/05/2000" //data de nascimento                
                );


            AlunoResultViewModel aluno = new AlunoResultViewModel(1, "20221123456", alunoCreateViewModel);

            Mock<IAlunoAppService> mockAlunoService = new Mock<IAlunoAppService>();
            mockAlunoService.Setup(m => m.Create(alunoCreateViewModel)).Returns(aluno);

            AlunoAppService alunoAppService = new AlunoAppService(mockAlunoService.Object);
            var s = alunoAppService.Create(alunoCreateViewModel);

            Assert.Equal(aluno, s);




        }
    }
}
