using AppCrud01.Application.AppService;
using AppCrud01.Application.ViewModel;
using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Services;
using Moq;
using Xunit;

namespace AppCrud01.Tests
{
    public class AlunoTestsUnit
    {
        [Fact]
        public void TestValidacaoAluno()
        {
            //Arrange
            int id = 1;
            Aluno aluno = new Aluno(1, "José da Silva", "123456");
            Mock<IAlunoService> mockAluno = new Mock<IAlunoService>();
            mockAluno.Setup(o => o.GetById(1)).Returns(aluno);

            //Act
            AlunoAppService alunoAppService = new AlunoAppService(mockAluno.Object); //autocomplete vs2022
            AlunoResultViewModel alunoesperado = alunoAppService.GetAluno(id);

            //Assert
            Assert.Equal("123456", alunoesperado.getMatricula());
        }

        [Fact]
        public void TestAlunoAppServices()
        {
            //Act
            AlunoAppService alunoAppServices = new AlunoAppService();
            
        }
    }
}