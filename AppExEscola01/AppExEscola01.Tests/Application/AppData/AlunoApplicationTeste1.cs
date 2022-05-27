using AppExEscola01.Application.AppService;
using AppExEscola01.Application.Interfaces;
using AppExEscola01.Application.ViewModel;
using Moq;
using Xunit;

namespace AppExEscola01.Tests.Application
{
    public class AlunoApplicationTeste1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            //string nome, string matricula, string cpf, string cep, string dataNascimento            
            AlunoCreateViewModel alunoIn = new AlunoCreateViewModel(
                "José da Silva",
                "176.031.590-75",
                "ze@ig.com.br",
                "23653-985",
                "12/05/2001"
                );

            AlunoResultViewModel aluno = new AlunoResultViewModel(
              1,
              "jose da silva",//nome
              "1254697", //matricula
              "ze@gmail.com",//email
              "176.031.590-75", //cpf               
              "20587120", //cep
              "12/05/2001"//data de nascimento
              );

            Mock<IAlunoAppService> mock = new Mock<IAlunoAppService>();
            mock.Setup(m => m.Create(alunoIn)).Returns(aluno);

            //Act
            AlunoAppService _alunoAppService = new AlunoAppService();
           _alunoAppService.setIAlunoAppService(mock.Object);

            //Retornando um booleano qualquer
            bool resultadoEsperado = false;

            //result deve retornar um objeto do tipo AlunoResultViewModel
            var result = _alunoAppService.Create(alunoIn);

            //resultadoObtido retorna um booleano
            var resultadoObtido = result.GetResultValidation();

            Assert.Equal(resultadoEsperado, resultadoObtido);

        }
    }
}
