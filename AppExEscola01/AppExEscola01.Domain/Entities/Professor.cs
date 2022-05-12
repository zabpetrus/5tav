using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Entities
{
    public class Professor
    {
        private int Id { get; set; }

        private string Nome { get; set; }

        private string DataNascimento { get; set; }

        private string Cep { get; set; }

        private string Cpf { get; set; }

        //Setters

        public void setID(int id)
        {
            Id = id;
        }               

        public void setNome(string nome)
        {
            Nome = nome;    
        }

        public void setNascimento(string dataNascimento)
        {
            DataNascimento = dataNascimento;
        }

        public void setCep(string cep)
        {
            Cep = cep;
        }

        public void setCpf(string cpf)
        {
            Cpf = cpf;
        }

        //Getters

        public int GetID() { return Id; }

        public string getNome() { return Nome; }

        public string getDataNascimento() { return DataNascimento; }

        public string getCep() { return Cep; }

        public string getCpf() { return Cpf; }


    }
}
