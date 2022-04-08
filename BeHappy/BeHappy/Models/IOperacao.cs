using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeHappy.Models
{
    public interface IOperacao //Service
    {
        public double soma();
        public double subracao();
        public double multiplicacao();
        public double divisao();
    }
}
