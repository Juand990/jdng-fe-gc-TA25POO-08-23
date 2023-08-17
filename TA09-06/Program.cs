using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA09_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coch1=new Coche("Renault","Megane", 1390, 75);
            coch1.MostrarDatos();
            Console.ReadKey();
        }
    }
}
