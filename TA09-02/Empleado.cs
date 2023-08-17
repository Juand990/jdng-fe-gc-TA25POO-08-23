using System;

namespace T09_02
{
    internal class Empleado
    {
        string nombre;
        int sueldo;
        public Empleado(string newNombre, int newSueldo)
        {
            this.nombre = newNombre;
            this.sueldo = newSueldo;
        }
        public void mostrardatos()
        {
            Console.WriteLine("Nombre: "+this.nombre+" con sueldo de "+this.sueldo);
        }
        public void pagar()
        {
            if (this.sueldo>3000)
            {
                Console.WriteLine("Tiene que pagar impuestos");
            }
            else
            {
                Console.WriteLine("No tiene que pagar impuestos");
            }
        }
    }
}