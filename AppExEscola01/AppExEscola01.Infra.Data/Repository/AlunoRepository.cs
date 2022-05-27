using AppExEscola01.Application.Interfaces;
using AppExEscola01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Infra.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        void IAlunoRepository.Create(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        void IAlunoRepository.Delete(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        List<Aluno> IAlunoRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Aluno IAlunoRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Aluno IAlunoRepository.GetByName(string name)
        {
            throw new NotImplementedException();
        }

        void IAlunoRepository.Update(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}
