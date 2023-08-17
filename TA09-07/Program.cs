using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA09_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1=new Persona();
            Persona p2 = new Persona("Carla",25,'M');
            Persona p3 = new Persona("Jorge",50,"12345678A",'H',75,200);
            p1.MostrarDatos();            
            p2.MostrarDatos();
            p3.MostrarDatos();
            Console.ReadKey();
        }
    }
}
