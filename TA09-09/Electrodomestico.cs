using System;

namespace TA09_09
{
    internal class Electrodomestico
    {
        protected double precioBase = 100;
        protected string color = "blanco";
        protected char consEnergetico = 'F';
        protected double peso = 5;
        //CONSTRUCTOR Default
        public Electrodomestico()
        {
        }
        //CONSTRUCTOR Precio,Peso + Default
        public Electrodomestico(double nPreciobase, double nPeso)
        {
            this.precioBase = nPreciobase;
            this.peso = nPeso;
        }
        //CONSTRUCTOR Todos
        public Electrodomestico(double nPreciobase, string nColor, char nConsEnergetico, double nPeso)
        {
            this.precioBase = nPreciobase;
            if (nColor.ToLower() == "blanco" || 
                nColor.ToLower() == "negro" || 
                nColor.ToLower() == "rojo" || 
                nColor.ToLower() == "azul" || 
                nColor.ToLower() == "gris")
            {
                this.color = nColor;
            }

            this.consEnergetico = nConsEnergetico;
            this.peso = nPeso;
        }
        //Mostrar datos
        public void MostrarDatos()
        {
            Console.WriteLine("Precio base: " + this.precioBase +
                              ", Color: " + this.color +
                              ", Consumo: " + this.consEnergetico +
                              ", Peso: " + this.peso);
        }
    }
}