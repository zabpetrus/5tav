using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeHappy.Models
{
    public class Duocalc
    {

        public int fator1 { get; set; }
        public int fator2 { get; set; }
        private IOperacao operacao;
        public Duocalc( IOperacao _operacao )
        {
            operacao = _operacao;
        }

        public Duocalc( int a, int b )
        {
            fator1 = a;
            fator2 = b;
        }

        public Duocalc() { }

        public int soma() { return fator1 + fator2; }
        public int subtracao() { return operacao.subracao();  }
        public int multiplicacao() { return operacao.multiplicacao(); }
        public int divisao() { return operacao.divisao(); }

    }
}
