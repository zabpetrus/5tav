using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Validation.Interfaces
{
    internal interface IValidaNome
    {
        bool validarTamanhoNome(string nome);
        bool validarCaracteresNome(string nome);
    }
}
