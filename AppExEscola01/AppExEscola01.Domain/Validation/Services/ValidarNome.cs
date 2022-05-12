using AppExEscola01.Domain.Validation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Validation.Services
{
    internal class ValidarNome : IValidaNome
    {
        public bool validarCaracteresNome(string nome)
        {
            return Regex.IsMatch(nome, @"[\p{L} ]+$");
        }

        public bool validarTamanhoNome(string nome)
        {
            return (nome == null || nome.Length > 3);
        }
    }
}
