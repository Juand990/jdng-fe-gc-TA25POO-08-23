using System;

namespace TA09_04
{    
    internal class Persona
    {
        string nombre;
        public Persona(string newNombre)
        {
            this.nombre=newNombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola, soy "+this.nombre);
        }

    }
}