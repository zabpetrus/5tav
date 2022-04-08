﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeHappy.Models
{
    public class Duocalc
    {

        public double fator1 { get; set; }
        public double fator2 { get; set; }
        private IOperacao operacao;
        public Duocalc( IOperacao _operacao )
        {
            operacao = _operacao;
        }

        public Duocalc( double a, double b )
        {
            fator1 = a;
            fator2 = b;
        }

        public Duocalc() { }

        public double soma() { return fator1 + fator2; }
        public double subtracao() { return fator1 - fator2;  }
        public double multiplicacao() { return fator1 * fator2; }
        public double divisao()
        {
            try
            {
                return fator1 / fator2;

            }catch(DivideByZeroException)
            {
                Console.WriteLine("Divisão por zero!");
            }
            return 0;
        }

    }
}
