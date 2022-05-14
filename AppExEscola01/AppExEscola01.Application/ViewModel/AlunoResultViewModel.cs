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

        public AlunoResultViewModel() { }
      
        public AlunoResultViewModel(AlunoCreateViewModel alunocreateViewModel)
        {
            _alunocreateViewModel = alunocreateViewModel;
        }

        public AlunoResultViewModel(int id, string nome, string matricula, string cpf, string cep, string dataNascimento)
        {
            Id = id;
            Nome = nome;
            Matricula = matricula;
            Cpf = cpf;
            Cep = cep;
            DataNascimento = dataNascimento;            
        }

        private int Id  { get; set; }

        private string Nome { get; set; }
        
        private string Matricula  { get; set; }

        private string Cpf { get; set; }

        private string Cep { get; set; }
       
        private string DataNascimento {  get; set; }           

        private bool ResultValidation { get; set; }

        private AlunoCreateViewModel _alunocreateViewModel { get; set; }



    //Getters

        public int GetId()
        {
            return Id;
        }

        public string GetMatricula()
        {
            return Matricula;
        }

         public bool GetResultValidation()
        {
            return ResultValidation;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public string GetCep()
        {
            return Cep;
        }

        public string GetDataNascimento()
        {
            return DataNascimento;
        }

        //Setters

        public void SetId(int value)
        {
            Id = value;
        }

        public void SetNome(string value)
        {
            Nome = value;
        }

        public void SetMatricula(string value)
        {
            Matricula = value;
        }

        public void SetResultValidation(bool value)
        {
            ResultValidation = value;
        }

        public void SetCpf(string value)
        {
            Cpf = value;
        }

        public void SetDataNascimento(string value)
        {
            DataNascimento = value;
        }

        public void SetCep(string value)
        {
            Cep = value;
        }



    }
}
