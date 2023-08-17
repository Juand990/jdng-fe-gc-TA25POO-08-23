using System;

namespace TA09_08
{
    internal class Password
    {
        int longitud=8;
        string contraseña;
        Random rnd=new Random();
        //Constructores
        public Password(string nContraseña)
        {
            this.contraseña = nContraseña;
        }
        public Password(int nLongitud)
        {
            this.longitud = nLongitud;
            string pass = "1234567890qwertyuiopasdfghjklñzxcvbnm";            
            for (int i = 0; i < nLongitud; i++)
            {                
                this.contraseña = this.contraseña + pass[this.rnd.Next(0, pass.Length)];
            }
        }
        //MostrarDatos
        public void MostrarDatos()
        {
            Console.WriteLine("Contraseña: "+this.contraseña);
        }

    }
}