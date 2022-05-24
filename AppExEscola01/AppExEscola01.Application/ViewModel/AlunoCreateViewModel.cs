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
        private string Nome;
        private string Cpf;
        private string Cep;
        private string DataNascimento;

        public AlunoCreateViewModel(){ }

        public AlunoCreateViewModel(string nome, string cpf, string cep, string dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Cep = cep;
            DataNascimento = dataNascimento;
        }

        

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string value)
        {
            Nome = value;
        }

        

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetCpf(string value)
        {
            Cpf = value;
        }

        

        public string GetCep()
        {
            return Cep;
        }

        public void SetCep(string value)
        {
            Cep = value;
        }

        

        public string GetDataNascimento()
        {
            return DataNascimento;
        }

        public void SetDataNascimento(string value)
        {
            DataNascimento = value;
        }
    }
}
