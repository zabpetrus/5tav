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
    public class AlunoResultViewModelTestes
    {
        [Fact]
        public void Test1()
        {            

            AlunoResultViewModel alunoResult = new AlunoResultViewModel(
                1,
                "Brutal Bull",
                "123456",
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
            AlunoCreateViewModel alunoCreateViewModel = new AlunoCreateViewModel("Jose", "23658745983", "pombomail@mail.com", "26875-589");
            Aluno aluno = new Aluno(alunoCreateViewModel);

            Mock<IAlunoService> mockAlunoService = new Mock<IAlunoService>();
           // mockAlunoService.Setup(m => m.Create(aluno)).Returns(true);


        }
    }
}
