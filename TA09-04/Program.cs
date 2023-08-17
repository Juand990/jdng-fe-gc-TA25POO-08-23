using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA09_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Rafael");
            Persona p2 = new Persona("Alejandro");
            p1.Saludar();
            p2.Saludar();
            Console.ReadKey();
        }
    }
}
