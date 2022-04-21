using AppCrud01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Services
{
    public interface IAlunoRepository
    {
        List<Aluno> GetAll();

        Aluno GetById(int id);

        void Create(Aluno aluno);

        void Update(Aluno aluno);

        void Remove(Aluno aluno);
    }
}
