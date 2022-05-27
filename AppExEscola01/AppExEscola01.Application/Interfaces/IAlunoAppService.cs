using AppExEscola01.Application.ViewModel;
using AppExEscola01.Domain.Entities;
using System.Collections.Generic;

namespace AppExEscola01.Application.Interfaces
{
    public interface IAlunoAppService
    {
        List<Aluno> GetAll();

        AlunoResultViewModel GetById(int id);

        Aluno GetByName(string name);

        AlunoResultViewModel Create(AlunoCreateViewModel aluno);

        bool CreateAluno(Aluno aluno);

        void Update(Aluno aluno);

        void Delete(Aluno aluno);

    }
}
