﻿using AppEscola02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola02.Domain.Interfaces
{
    public interface IAlunoService
    {
        bool Create(Aluno aluno);
    }
}
