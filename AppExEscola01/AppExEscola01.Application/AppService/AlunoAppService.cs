using AppExEscola01.Application.Interfaces;
using AppExEscola01.Application.ViewModel;
using AppExEscola01.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AppExEscola01.Application.AppService
{

    //Antes implementava a interface IAlunoService
    //Agora passou  a ser a interface IAlunoAppService
    public class AlunoAppService : IAlunoAppService
    {
        private IAlunoAppService _alunoAppService;
        //private IAlunoService _alunoService;


        public AlunoAppService(){ }

        // Versão anterior - foi oficialmente anulada não sei porque
        // public AlunoAppService(IAlunoService alunoService) {  _alunoService = alunoService;  }
        public AlunoAppService(IAlunoAppService alunoAppService) { this._alunoAppService = alunoAppService; }


        public AlunoResultViewModel Create(AlunoCreateViewModel alunoCreateViewModel)
        {
            Aluno aluno = new Aluno();
            aluno.setNome("sdsad");
            aluno.setCPF("88775228017");
            aluno.setCEP("23658-888");
            aluno.setEmail("ghjhgjhgj@asdad.com");
            aluno.setNascimento("2/2/222");
            aluno.CriaMatricula();

            var retorno = _alunoAppService.CreateAluno(aluno); //validação com booleano
            if (retorno == true)
            {
                throw new Exception("Outro caso!");
            }
           


            AlunoResultViewModel result = new AlunoResultViewModel(1, "20221123456", alunoCreateViewModel);
            return result;                       


            // return _alunoAppService.Create(alunoCreateViewModel);

        }


        public bool CreateAluno(AlunoCreateViewModel alunoCreateViewModel)
        {
            if (alunoCreateViewModel == null)
            {
                return false;
            }
            return true;
            // return _alunoAppService.CreateAluno(alunoCreateViewModel);
        }

        public bool CreateAluno(Aluno aluno)
        {
            if(aluno == null) {
                return false;
            }
            return true;
            //return _alunoAppService.CreateAluno(aluno);
        }

        public void Delete(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> GetAll()
        {
            return _alunoAppService.GetAll();   
        }

        public AlunoResultViewModel GetById(int id)
        {
            return _alunoAppService.GetById(id);
        }

        public Aluno GetByName(string name)
        {
            return _alunoAppService.GetByName(name);
        }

        public void Update(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}
