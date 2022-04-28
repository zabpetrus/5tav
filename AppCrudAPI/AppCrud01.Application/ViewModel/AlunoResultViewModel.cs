using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.ViewModel
{
    public class AlunoResultViewModel
    {
        private int id { get; set; }

        private string nome { get; set; }

        private string cpf { get; set; }

        private string matricula { get; set; }

        private string curso { get; set; }

        private string endereco { get; set; }

        private string cep { get; set; }

        private string cidade { get; set; }

        private string uf { get; set; }

        DateTime datanascimento { get; set; }

        DateTime dataingresso { get; set; }

       //Getters
        public int getId(){ return id; }
        public string getNome() { return nome; }
        public string getCpf() { return cpf; }
        public string getMatricula() { return matricula; }
        public string getCurso() { return curso; } 
        public string getEndereco() { return endereco; }    
        public string getCep() { return cep; }
        public DateTime GetDatanascimento() { return datanascimento; }  
        public DateTime GetDataingresso() { return dataingresso; }  
                    
        //Setters

        public void setId( int id ) { this.id = id; }
        public void setNome( string nome ) { this.nome = nome; }    
        public void setCpf( string cpf ) { this.cpf = cpf; } 
        public void setMatricula( string matricula ) { this.matricula = matricula; }
        public void setCurso( string curso ) { this.curso = curso; }
        public void setEndereco( string endereco ) { this.endereco = endereco; }
        public void setCep( string cep) { this.cep = cep; }
        public void setDataingresso( DateTime dataingresso ) { this.dataingresso = dataingresso; }
        public void setDataNascimento( DateTime dataNascimento) { this.datanascimento = dataNascimento; }


    }
}
