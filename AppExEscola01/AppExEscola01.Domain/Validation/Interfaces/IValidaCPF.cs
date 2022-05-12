using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Validation.Interfaces
{
    internal interface IValidaCPF
    {
        public bool validaTamanhoCPF(string cpf);

        public bool validaNumeracaoCPF(string cpf);

        public bool validaSeSomenteNumeros(string cpf);
    }
}
