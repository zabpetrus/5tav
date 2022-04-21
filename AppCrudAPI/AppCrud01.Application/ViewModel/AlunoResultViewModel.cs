using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.ViewModel
{
    public class AlunoResultViewModel
    {
        int id { get; set; }
        string nome { get; set; }

        string cpf { get; set; }

        string matricula { get; set; }

        string curso { get; set; }

        string endereco { get; set; }

        string cep { get; set; }

        string cidade { get; set; }

        string uf { get; set; }

        DateTime datanascimento { get; set; }

        DateTime dataingresso { get; set; }
    }
}
