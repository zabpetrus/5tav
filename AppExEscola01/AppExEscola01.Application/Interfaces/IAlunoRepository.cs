using AppExEscola01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Application.Interfaces
{
    internal interface IAlunoRepository
    {
        List<Aluno> GetAll();

        Aluno GetById(int id);

        Aluno GetByName(string name);

        void Create(Aluno aluno);

        void Update(Aluno aluno);

        void Delete(Aluno aluno);   
    }
}
