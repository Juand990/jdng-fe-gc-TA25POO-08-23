using System;

namespace TA09_06
{
    internal class Coche
    {
        string marca;
        string modelo;
        int cilindrada;
        double potencia;
        public Coche(string newMarca, string newModelo, int newCilindrada, double newPotencia)
        {
            this.marca = newMarca;
            this.modelo = newModelo;
            this.cilindrada = newCilindrada;
            this.potencia = newPotencia;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Marca: "+this.marca+ ", Modelo: "+this.modelo+ ", Cilindrada: "+this.cilindrada+ ", Potencia: "+this.potencia);
        }

    }
}