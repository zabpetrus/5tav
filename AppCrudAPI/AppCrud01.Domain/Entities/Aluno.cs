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
            
                

    }
}
