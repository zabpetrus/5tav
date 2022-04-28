using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Infra.Http.Interfaces
{
    internal interface ICorreiosHttp
    {
        double GetValorFrete(string cepDestino);
        string GetEndereco(string cepDestino);
    }
}
