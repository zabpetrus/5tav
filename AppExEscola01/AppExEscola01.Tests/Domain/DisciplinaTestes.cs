using AppExEscola01.Domain.Entities;
using Xunit;

namespace AppExEscola01.Tests.Domain
{
    public class DisciplinaTestes
    {
        [Fact]
        public void TestDisciplinaObject1()
        {
            Disciplina disciplina = new Disciplina();
            disciplina.setCodigoNumerico(5715);
            disciplina.setNome("Avaliação da Fertilidade do Solo e do Estado Nutricional das Plantas");
            Assert.NotNull(disciplina);
        }


    }
}
