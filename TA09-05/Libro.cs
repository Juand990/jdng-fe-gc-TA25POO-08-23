namespace TA09_05
{
    internal class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;
        public Libro(string newAutor, string newTitulo, string newUbicacion)
        {
            this.autor = newAutor;
            this.titulo = newTitulo;
            this.ubicacion = newUbicacion;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        public string GetTitulo()
        {
            return this.titulo;
        }
        public string GetUbicacion()
        {
            return this.ubicacion;
        }        
    }
}