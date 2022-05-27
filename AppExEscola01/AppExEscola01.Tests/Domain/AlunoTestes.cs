using AppExEscola01.Domain.Entities;
using Xunit;

namespace AppExEscola01.Tests.Domain
{
    public class AlunoTestes
    {
        [Fact]
        public void TestAlunoObject1()
        {
            Aluno aluno = new Aluno();
            aluno.setID(1);
            aluno.setMatricula("1252256");
            aluno.setNome("Johnantan Cesar de Araújo");
            aluno.setCPF("697.660.160-03");
            aluno.setNascimento("10/05/2000");
            aluno.setCEP("21630-248");
            Assert.NotNull(aluno);
        }


    }
}
