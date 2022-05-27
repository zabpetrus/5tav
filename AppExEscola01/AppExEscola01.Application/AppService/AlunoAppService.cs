using AppExEscola01.Application.Interfaces;
using AppExEscola01.Application.ViewModel;
using AppExEscola01.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AppExEscola01.Application.AppService
{
    public class AlunoAppService : IAlunoAppService
    {
        private IAlunoAppService _appService { get; set; }  //propriedade necess�ria

        public AlunoAppService() { }
        
        //No momento da inje��o tem que tirar esse construtor. Caso contr�rio, d� erro de Agrega��o.
        //public AlunoAppService(IAlunoAppService appService) { _appService = appService; }
                       

        public AlunoResultViewModel Create(AlunoCreateViewModel alunocreateviewmodel)
        {
            Aluno aluno = new Aluno();
            aluno.setNome(alunocreateviewmodel.GetNome());
            aluno.setCPF(alunocreateviewmodel.GetCpf());
            aluno.setCEP(alunocreateviewmodel.GetCep());
            aluno.setEmail(alunocreateviewmodel.GetEmail());
            aluno.setNascimento(alunocreateviewmodel.GetDataNascimento());
            aluno.CriaMatricula();

            var retorno = CreateAluno(aluno);
            if (retorno)
            {
                 AlunoResultViewModel result = new AlunoResultViewModel(
                    1, //int id,
                    aluno.getNome(), //string nome,
                    aluno.getMatricula(), //string matricula,
                    aluno.getEmail(),//string email,
                    aluno.getCpf(), //string cpf,
                    aluno.getCep(), //string cep,
                    aluno.getDataNascimento() //string dataNascimento
                 );
                 return result;
            }
            throw new Exception("aluno est� nulo!");           

           // return _appService.Create(alunocreateviewmodel);
        }

        public bool CreateAluno(Aluno aluno)
        {
            if (aluno == null){
                return false;
            }
            return true;

            //return _appService.CreateAluno(aluno);
        }

        public void Delete(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> GetAll()
        {
            throw new NotImplementedException();
        }

        public AlunoResultViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Aluno GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        //Setter da propriedade para o mock tradicional funcionar
        //Com IAlunoAppService j� injetado em Program, se colocar no construtor, d� erro de Agrega��o, uma vez que ele j� est� carregado em mem�ria
        //Mas pro mock funcionar ele precisa estar no construtor...
        public void setIAlunoAppService( IAlunoAppService alunoAppService )
        {
            if(_appService == null)
            {
                _appService = alunoAppService;
            }            
        }
    }
}
