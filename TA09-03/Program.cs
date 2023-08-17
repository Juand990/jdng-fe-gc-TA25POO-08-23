using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA09_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones op1 = new Operaciones(10, 5);
            Console.WriteLine("Suma: " + op1.Sumar());
            Console.WriteLine("Resta: " + op1.Resta());
            Console.WriteLine("Multiplicacion: " + op1.Mult());
            Console.WriteLine("Division: " + op1.Dividir());
            Console.ReadKey();
        }
    }
}
