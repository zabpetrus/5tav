using AppExEscola01.Application.AppService;
using AppExEscola01.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppExEscola01.Tests.Application
{
    public class AlunoViewModelTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            //string nome, string matricula, string cpf, string cep, string dataNascimento

            bool resultadoEsperado = false;

            AlunoCreateViewModel alunoIn = new AlunoCreateViewModel(
                "José da Silva",
                "562.345.897-45",
                "ze@ig.com.br",
                "23653-985"
                );

            //Act
            AlunoAppService _alunoAppService = new AlunoAppService();
            var result = _alunoAppService.Create(alunoIn);
            Assert.Equal(resultadoEsperado, result.GetResultValidation());

        }
    }
}
