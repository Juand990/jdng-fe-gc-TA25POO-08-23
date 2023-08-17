using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado("Fernando",2500);
            Empleado emp2 = new Empleado("Elisabeth", 5000);
            emp1.mostrardatos();
            emp1.pagar();
            emp2.mostrardatos();
            emp2.pagar();
            Console.ReadKey();
        }
    }
}
