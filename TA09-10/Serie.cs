using System;

namespace TA09_10
{
    internal class Serie
    {
        string titulo = "";
        int numTemporadas = 3;
        bool entregado = false;
        string genero = "";
        string creador = "";
        //Constructor Defecto
        public Serie()
        {}
        //Constructor Titulo, Creador + Defecto
        public Serie(string nTitulo,string nCreador)
        {
            this.titulo = nTitulo;
            this.creador = nCreador;
        }
        //Constructor Todo menos entregado
        public Serie(string nTitulo,int nNumTemporadas,string nGenero, string nCreador)
        {
            this.titulo = nTitulo;
            this.numTemporadas= nNumTemporadas;
            this.genero = nGenero;
            this.creador = nCreador;
        }
        //Mostrar Datos
        public void MostrarDatos()
        {
            Console.WriteLine("Titulo: "+this.titulo+
                              ", Numero Temporadas:"+this.numTemporadas+
                              ", Genero: "+this.genero+
                              ", Creador: "+this.creador
                );
        }
    }
}