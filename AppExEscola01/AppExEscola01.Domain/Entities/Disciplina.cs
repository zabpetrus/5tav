using System;

namespace AppExEscola01.Domain.Entities
{
    public class Disciplina
    {

        private int Id;

        private int CodigoNumerico;

        private string Nome;

        public Disciplina(int id, int codigoNumerico, string nome)
        {
            Random random = new Random();
            Id = random.Next(0, 1000000);
            CodigoNumerico = codigoNumerico;
            Nome = nome;
        }

        public Disciplina()
        {
            Random random = new Random();
            Id = random.Next(0, 1000000);
        }

        //Setters

        public void setCodigoNumerico(int codigoNumerico)
        {
            CodigoNumerico = codigoNumerico;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        //Getters
        public int getID()
        {
            return Id;
        }

        public int getCodigoNumerico()
        {
            return CodigoNumerico;
        }

        public string getNome()
        {
            return Nome;
        }



    }
}
