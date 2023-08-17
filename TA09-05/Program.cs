using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA09_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1=new Libro("J. K. Rowling", "Harry Potter", "Colegio Hogwarts");
            Console.WriteLine("Autor: "+ libro1.GetAutor());
            Console.WriteLine("Titulo: " + libro1.GetTitulo());
            Console.WriteLine("Ubicacion: " + libro1.GetUbicacion());
            Console.ReadKey();
        }
    }
}
