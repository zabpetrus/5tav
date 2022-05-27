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
    public class AlunoAppServiceTestes2
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            //string nome, string matricula, string cpf, string cep, string dataNascimento            
            AlunoCreateViewModel alunoIn = new AlunoCreateViewModel(
                "José da Silva",
                "562.345.897-45",
                "ze@ig.com.br",
                "23653-985",
                "12/05/2001"
                );

            AlunoResultViewModel aluno = new AlunoResultViewModel(
              1,
              "jose da silva",//nome
              "1254697", //matricula
              "ze@gmail.com",//email
              "34567891055", //cpf               
              "20587120", //cep
              "12/05/2001"//data de nascimento
              );

            Mock<IAlunoAppService> mock = new Mock<IAlunoAppService>();
            mock.Setup(m => m.Create(alunoIn)).Returns(aluno);

            //Act
            AlunoAppService _alunoAppService = new AlunoAppService(mock.Object);

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
