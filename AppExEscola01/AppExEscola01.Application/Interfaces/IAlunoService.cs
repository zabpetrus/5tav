using AppExEscola01.Application.ViewModel;
using AppExEscola01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Application.Interfaces
{
    internal interface IAlunoService
    {
        List<Aluno> GetAll();

        AlunoResultViewModel GetById(int id);

        Aluno GetByName(string name);

        AlunoResultViewModel Create(AlunoCreateViewModel aluno);

        void Update(Aluno aluno);   

        void Delete(Aluno aluno);
    }
}
