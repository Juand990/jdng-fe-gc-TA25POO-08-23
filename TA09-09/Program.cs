using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA09_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico elec1 = new Electrodomestico();
            Electrodomestico elec2 = new Electrodomestico(85, 6.5);
            Electrodomestico elec3 = new Electrodomestico(70, "AzUl", 'E', 3.25);
            Electrodomestico elec4 = new Electrodomestico(49.99, "VERDE", 'F', 4);
            elec1.MostrarDatos();
            elec2.MostrarDatos();
            elec3.MostrarDatos();
            elec4.MostrarDatos();
            Console.ReadKey();
        }
    }
}
