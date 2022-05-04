using AppMVCAplication.Models;
using System;

namespace AppMVCAplication
{
    public class Calculadora
    {
        //Chamando a interface
        public ICalculadora icalculadora;

        public Calculadora() { }

        public Calculadora(ICalculadora _calculadora)
        {
            icalculadora = _calculadora;
        }


        public int soma(int v1, int v2) { return v1 + v2; }

        public int subtrair(int v1, int v2) { return v1 - v2; }

        public int multiplicar(int v1, int v2) { return v1 * v2; }

        public int dividir(int v1, int v2)
        {
            int n = 0;
            try { n = v1 / v2; } catch (DivideByZeroException e) { Console.WriteLine(e); }
            return n;
        }

        public double soma(double v1, double v2) { return v1 + v2; }

        public double subtrair(double v1, double v2) { return v1 - v2; }

        public double multiplicar(double v1, double v2) { return v1 * v2; }

        public double dividir(double v1, double v2)
        {
            double n = 0;
            try { n = v1 / v2; } catch (DivideByZeroException e) { Console.WriteLine(e); }
            return n;
        }

    }
}
