using System;

namespace TA09_07
{
    internal class Persona
    {
        private string nombre = "";
        private int edad = 0;
        private string dni;
        private char sexo = 'H';
        private double peso = 0;
        private int altura = 0;
        //Por defecto
        public Persona()
        {
        }
        //nombre, edad, sexo,  resto defecto
        public Persona(string nNombre, int nEdad, char nSexo)
        {
            this.nombre = nNombre;
            this.edad = nEdad;
            this.sexo = nSexo;
        }
        //Todos los atributos
        public Persona(string nNombre, int nEdad, string nDni, char nSexo, double nPeso, int nAltura)
        {
            this.nombre = nNombre;
            this.edad = nEdad;
            this.dni = nDni;
            this.sexo = nSexo;
            this.peso = nPeso;
            this.altura = nAltura;
        }
        //GETs
        public string GetNombre()
        {
            return this.nombre;
        }
        public int GetEdad()
        {
            return this.edad;
        }
        public string GetDni()
        {
            return this.dni;
        }
        public char GetSexo()
        {
            return this.sexo;
        }
        public double GetPeso()
        {
            return this.peso;
        }
        public int GetAltura()
        {
            return this.altura;
        }
        //Sets
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        public void SetSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
        }
        public void SetAltura(int altura)
        {
            this.altura = altura;
        }
        //Mostrar datos
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + this.nombre +
                              ", Edad: " + this.edad +
                              ", DNI: " + this.dni +
                              ", Sexo: " + this.sexo +
                              ", Peso: " + this.peso +
                              ", Altura: " + this.altura
                );
        }
       
    }
}