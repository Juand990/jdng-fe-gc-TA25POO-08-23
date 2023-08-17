using System;

namespace TA09_03
{
    internal class Operaciones
    {
        int valor1;
        int valor2;
        public Operaciones(int newValor1, int newValor2)
        {
            this.valor1 = newValor1;
            this.valor2 = newValor2;
        }
        public double Sumar()
        {
            double suma = this.valor1 + this.valor2;
            return suma;
        }
        public double Resta()
        {
            double resta = this.valor1 - this.valor2;
            return resta;
        }
        public double Mult()
        {
            double mult = this.valor1 * this.valor2;
            return mult;
        }
        public double Dividir()
        {
            double division = this.valor1 / this.valor2;
            return division;
        }

    }
}