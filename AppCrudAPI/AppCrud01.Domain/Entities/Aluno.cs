using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class Aluno
    {
        private int Id {  get; set; }

        private string Nome { get; set; }

        private string Matricula { get; set; }

        public Aluno() { }

        public Aluno(int id, string nome, string matricula)
        {
            Id = id;
            Nome = nome;   
            Matricula = matricula;
        }

        //Getters
        public int getId() { return Id; }
        public string getNome() { return Nome; }
        public string getMatricula() { return Matricula; }


        //Setters
        public void setId(int id) { Id = id; }
        public void setNome(string nome) { Nome = nome; }
        public void setMatricula(string matricula) { Matricula = matricula; }

    }
}
