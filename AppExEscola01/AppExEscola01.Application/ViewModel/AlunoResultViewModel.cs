using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Application.ViewModel
{
    //View Model de consulta - partindo do fato que o aluno já existe
    public class AlunoResultViewModel
    {
        private int Id { get; set; }

        private string Nome { get; set; }

        private string Matricula { get; set; }

        private string Cpf { get; set; }

        private string Cep { get; set; }

        private string DataNascimento { get; set; }
    }
}
