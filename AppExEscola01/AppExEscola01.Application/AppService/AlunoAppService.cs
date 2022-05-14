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

        private Aluno _aluno;

        public AlunoResultViewModel Create(AlunoCreateViewModel aluno)
        {
            //throw new NotImplementedException();
            AlunoResultViewModel alunoResult = new AlunoResultViewModel(
                1,
                "Brutal Bull",
                "123456",
                "612.547.851-36",
                "21589-555",
                "20/09/2001"
               );

            alunoResult.SetResultValidation(false);
            return alunoResult;
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
