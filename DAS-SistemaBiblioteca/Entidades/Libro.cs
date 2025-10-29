namespace Entidades
{
    public enum EstadoLibro
    {
        Disponible,
        Prestado 
    }
    public class Libro
    {
        private string isbn;
        private string titulo;
        private string autor;
        private EstadoLibro estado;
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public EstadoLibro Estado { get; set; }

    }
}


