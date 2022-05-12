using AppExEscola01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppExEscola01.Tests.Domain
{
    public class ProfessorTeste
    {
        [Fact]
        public void TestProfessorObject1()
        {
            Professor professor = new Professor();
            professor.setID(1);
            professor.setNome("Afonso Nunes Soares Mendes");
            professor.setNascimento("14/07/1982");
            professor.setCpf("698.365.987-56");
            professor.setCep("32565-859");

            Assert.NotNull(professor);

        }
    }
}
