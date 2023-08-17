using System;

namespace T09_01
{
    internal class Alumno
    {
        //Atributos
        string nombre;
        int edad;
        //Constructor
        public Alumno(string newNombre, int newEdad)
        {
            this.nombre = newNombre;
            this.edad= newEdad;
        }
        //Mostrar datos
        public void mostrarDatos()
        {
            Console.WriteLine("Se llama "+this.nombre+" con edad de "+this.edad);
        }
        //Es mayor o no
        public void esMayor()
        {
            if (this.edad>18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else {
                Console.WriteLine("No es mayor de edad");
            }
        }
    }
}