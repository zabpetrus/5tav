using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.ViewModel
{
    public class AlunoViewModel
    {
        private string nome { get; set; }

        private string cpf { get; set; }

        private string matricula { get; set; }

        private string curso { get; set; }

        private string endereco { get; set; }

        private string cep { get; set; }

        private string cidade { get; set; }

        private string uf { get; set; }

        DateTime datanascimento { get; set; }

        //Getters

        public string getNome() { return nome; }
        public string getCpf() { return cpf; }  
        public string getMatricula() { return matricula; }
        public string getCurso() { return curso; }            
        public string getEndereco() { return endereco; }
        public string getCep() { return cep; }
        public string getUF() { return uf; }
        public DateTime getDatanascimento() { return datanascimento; }

        //Setters
        public void setNome( string nome) { this.nome = nome; }
        public void setCPF ( string cpf ) { this.cpf = cpf; }


        

    }
}
