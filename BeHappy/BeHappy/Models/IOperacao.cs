using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeHappy.Models
{
    public interface IOperacao //Service
    {
        public int soma();
        public int subracao();
        public int multiplicacao();
        public int divisao();
    }
}
