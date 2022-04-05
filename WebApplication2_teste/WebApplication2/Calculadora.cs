using System;

namespace WebApplication2
{
    public class Calculadora
    {       

        public int soma(int v1, int v2)
        {
            return v1 + v2;
        }

        public int subtrair(int v1, int v2)
        {
            return v1 - v2;
        }

        public int multiplicar(int v1, int v2)
        {
            return v1 * v2;
        }

        public int dividir(int v1, int v2)
        {
            int n = 0;
            try
            {
                n = v1 / v2;
            }catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            return n;
        }
    }
}
