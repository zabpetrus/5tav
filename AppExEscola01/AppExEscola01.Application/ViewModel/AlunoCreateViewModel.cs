using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Application.ViewModel
{
    //Campos de inserção de aluno - metodo POST
    //Antes de se matricular não há id e nem matrícula.
    public class AlunoCreateViewModel
    {
      
        public AlunoCreateViewModel(string nome, string cpf, string cep, string dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Cep = cep;
            DataNascimento = dataNascimento;
        }

        private string Nome { get; set; }

        private string Cpf { get; set; }

        private string Cep { get; set; }

        private string DataNascimento { get; set; }


    }
}
