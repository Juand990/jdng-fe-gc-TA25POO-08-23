using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TA09_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password pass1 = new Password("Qwerty1");
            Password pass2 = new Password(8);

            pass1.MostrarDatos();
            pass2.MostrarDatos();
            Console.ReadKey();
        }
    }
}
