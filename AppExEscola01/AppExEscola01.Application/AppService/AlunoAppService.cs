using AppExEscola01.Application.Interfaces;
using AppExEscola01.Application.ViewModel;
using AppExEscola01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Application.AppService
{
    public class AlunoAppService : IAlunoService
    {

        private IAlunoService _alunoService;
        private AlunoCreateViewModel alunoCreateViewModel;

        public AlunoAppService()
        {
        }

        public AlunoAppService(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public AlunoAppService(AlunoCreateViewModel alunoCreateViewModel)
        {
            this.alunoCreateViewModel = alunoCreateViewModel;
        }

        public AlunoResultViewModel Create(AlunoCreateViewModel aluno)
        {
            //throw new NotImplementedException();

            Aluno alunoNew = new Aluno(
                aluno.GetNome(),
                aluno.GetCep(),
                aluno.GetCep(),
                aluno.GetDataNascimento()
            );
            AlunoResultViewModel alunoResult = new AlunoResultViewModel();

            return null;
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
    }
}
