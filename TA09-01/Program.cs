using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alum1 = new Alumno("Luis",15);
            Alumno alum2 = new Alumno("Ana", 21);
            alum1.mostrarDatos();
            alum1.esMayor();
            alum2.mostrarDatos();
            alum2.esMayor();
            Console.ReadKey();
        }
    }
}
