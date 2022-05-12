using AppExEscola01.Domain.Validation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppExEscola01.Domain.Validation.Services
{
    internal class ValidaCPF : IValidaCPF
    {
        //Verifica se o número do cpf é válido
        public bool validaNumeracaoCPF(string @cpf)
        {
            FormatCPFValidation formatCPFValidation = new FormatCPFValidation(cpf);
            return formatCPFValidation.getResult();
        }

        //Verifica se o numero do cpf informado tem somente números
        public bool validaSeSomenteNumeros(string @cpf)
        {
            string aux = Regex.Replace(cpf, "[^0-9]", "");
            return Regex.IsMatch(aux, @"^\d+$");
        }

        //O numero do cpf tem 11 digitos. Este método verifica se a string tem 11 caracteres
        public bool validaTamanhoCPF(string @cpf)
        {
            string aux = Regex.Replace(cpf, "[^0-9]", "");
            return (aux.Length == 11);
        }
    }
}
