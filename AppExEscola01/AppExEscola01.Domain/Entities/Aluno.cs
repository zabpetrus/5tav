using AppExEscola01.Domain.Validation.Services;
using System;

namespace AppExEscola01.Domain.Entities
{
    public class Aluno
    {

        private int Id { get; set; }

        private string Matricula { get; set; }

        private string Nome { get; set; }

        private string Email { get; set; }

        private string Cpf { get; set; }

        private string Cep { get; set; }

        private string DataNascimento { get; set; }


        //Setters

        public void setID(int id)
        {
            Id = id;
        }

        public void setMatricula(string matricula)
        {
            Matricula = matricula;
        }

        public void setCPF(string cpf)
        {
            ValidaCPF validaCPF = new ValidaCPF();
            bool tamanhovalido = validaCPF.validaTamanhoCPF(cpf);
            bool temSoNumeros = validaCPF.validaSeSomenteNumeros(cpf);
            bool numerovalido = validaCPF.validaNumeracaoCPF(cpf);

            if (!tamanhovalido)
            {
                throw new Exception("O numero do cpf " + cpf  + "está errado.");
            }
            else if (!temSoNumeros)
            {
                throw new Exception("Tem algo mais ai. Corrija isso!");
            }
            else if (!numerovalido)
            {
                throw new Exception("O CPF" + cpf + "não existe!!!");
            }
            else
            {
                Cpf = cpf;
            }
        }

        public void CriaMatricula()
        {
            Random numerorandom = new Random();
            string temp = numerorandom.Next().ToString();
            Matricula = "1";

        }

        public void setCEP(string cep)
        {
            Cep = cep;
        }

        public void setNascimento(string datanascimento)
        {
            DataNascimento = datanascimento;
        }

        public void setNome(string nome)
        {
            ValidarNome validarNome = new ValidarNome();
            bool caracteresvalidos = validarNome.validarCaracteresNome(nome);
            bool tamanhocerto = validarNome.validarTamanhoNome(nome);

            if (!caracteresvalidos)
            {
                throw new Exception("Tem caracteres inválidos aí!");
            }
            else if (!tamanhocerto)
            {
                throw new Exception("Nome muito pequeno, não?");
            }
            else
            {
                Nome = nome;
            }

        }

        public void setEmail(string email)
        {
            Email = email;
        }

        //Getters

        public int getID() { return Id; }

        public string getNome() { return Nome; }

        public string getMatricula() { return Matricula; }

        public string getCpf() { return Cpf; }

        public string getCep() { return Cep; }

        public string getDataNascimento() { return DataNascimento; }

        public string getEmail() { return Email; }


        //Construtores

        public Aluno() { }

        public Aluno(string nome, string cep, string cpf, string email, string datanascimento)
        {
            Nome = nome;
            Cep = cep;
            Cpf = cpf;
            Email = email;
            DataNascimento = datanascimento;
        }

        public Aluno(int id, string matricula, string nome, string email, string cpf, string cep, string dataNascimento)
        {
            Id = id;
            Matricula = matricula;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Cep = cep;
            DataNascimento = dataNascimento;
        }

    }
}
