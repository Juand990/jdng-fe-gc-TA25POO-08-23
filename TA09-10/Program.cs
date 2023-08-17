using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA09_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie serie1=new Serie();
            Serie serie2 = new Serie("The Witcher", "Netflix");
            Serie serie3 = new Serie("The Walking Dead",11,"Accion","Netflix");
            serie1.MostrarDatos();
            serie2.MostrarDatos();
            serie3.MostrarDatos();

            Console.ReadKey();
        }
    }
}
