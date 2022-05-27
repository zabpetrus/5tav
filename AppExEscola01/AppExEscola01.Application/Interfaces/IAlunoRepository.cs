using AppExEscola01.Domain.Entities;
using System.Collections.Generic;

namespace AppExEscola01.Application.Interfaces
{
    public interface IAlunoRepository
    {
        List<Aluno> GetAll();

        Aluno GetById(int id);

        Aluno GetByName(string name);

        void Create(Aluno aluno);

        void Update(Aluno aluno);

        void Delete(Aluno aluno);
    }
}
