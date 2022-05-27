using AppExEscola01.Application.ViewModel;
using AppExEscola01.Domain.Entities;
using System.Collections.Generic;

namespace AppExEscola01.Application.Interfaces
{
    public interface IAlunoService
    {
        List<Aluno> GetAll();

        AlunoResultViewModel GetById(int id);

        Aluno GetByName(string name);

        //Método anterior - create original
        AlunoResultViewModel Create(AlunoCreateViewModel aluno);

        //Novo método  - Sincronizado om IAlunoAppService
        bool CreateAluno(AlunoCreateViewModel aluno);

        void Update(Aluno aluno);

        void Delete(Aluno aluno);
    }
}
