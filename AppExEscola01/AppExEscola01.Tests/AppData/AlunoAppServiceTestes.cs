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

namespace AppExEscola01.Tests.AppData
{
    public class AlunoAppServiceTestes
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            //string nome, string email, string cpf, string cep, string dataNascimento
            AlunoCreateViewModel alunoIn = new AlunoCreateViewModel(
                "jose da silva",//nome
                "ze@gmail.com",//email
                "34567891055", //cpf               
                "20587120", //cep
                "12/05/2001"//data de nascimento
                );


            //public Aluno(string nome, string cep, string cpf, string email, string datanascimento)
            Aluno aluno = new Aluno(
                "jose da silva",//nome
                "ze@gmail.com",//email
                "34567891055", //cpf               
                "20587120", //cep
                "12/05/2001"//data de nascimento
                );

            //Mudando IAlunoService para IAlunoAppService
            Mock<IAlunoAppService> mockAlunoService = new Mock<IAlunoAppService>();
            // Mock<IAlunoService> mockAlunoService = new Mock<IAlunoService>();


            //referente a [ bool CreateAluno(AlunoCreateViewModel aluno) ]->
            //O metodo recebe um objeto do tipo AlunoCreateViewModel e retorna um bool
            mockAlunoService.Setup(m => m.CreateAluno(alunoIn)).Returns(false); 

            AlunoAppService _alunoAppService = new AlunoAppService(mockAlunoService.Object); 
            

            //Verificar se ele está devidamente implementado
            var result = _alunoAppService.CreateAluno(alunoIn);

            //Valor de referencia
            var resultEsperado = false;

            // Assert
            Assert.Equal(resultEsperado, result);

        }

        [Fact]
        public void Test2()
        {
            // Arrange
            //string nome, string email, string cpf, string cep, string dataNascimento
            AlunoCreateViewModel alunoIn = new AlunoCreateViewModel(
                "jose da silva",//nome
                "ze@gmail.com",//email
                "34567891055", //cpf               
                "20587120", //cep
                "12/05/2001"//data de nascimento
                );


            //public Aluno(string nome, string cep, string cpf, string email, string datanascimento)
            Aluno aluno = new Aluno(
                "jose da silva",//nome
                "ze@gmail.com",//email
                "34567891055", //cpf               
                "20587120", //cep
                "12/05/2001"//data de nascimento
                );


            AlunoResultViewModel alunoTeste = new AlunoResultViewModel(
               1,
              "jose da silva",//nome
              "20221123456", //matricula
              "ze@gmail.com",//email
              "34567891055", //cpf               
              "20587120", //cep
              "12/05/2001"//data de nascimento
              );


            //Mudando IAlunoService para IAlunoAppService
            Mock<IAlunoAppService> mockAlunoService = new Mock<IAlunoAppService>();
            // Mock<IAlunoService> mockAlunoService = new Mock<IAlunoService>();

            mockAlunoService.Setup(m => m.Create(alunoIn)).Returns(alunoTeste);

            // Act
            AlunoAppService _alunoAppService = new AlunoAppService(mockAlunoService.Object);
            string resultEsperado = "20221123456";

            

            //Verificar se ele está devidamente implementado
            var result = _alunoAppService.Create(alunoIn);

            // Assert
            Assert.Equal(resultEsperado, result.GetMatricula());
            //Assert.Equal("34567891055", result.GetCpf());
        }
    }
}
