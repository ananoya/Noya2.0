namespace Entidades
{
    public enum EstadoLibro
    {
        disponible,
        prestado,
    }

    public class Libro
    {
        public string ISBN {  get; set; }
        public string  Titulo {  get; set; }
        public string Autor {  get; set; }
        public EstadoLibro Estado { get; set; }
        
    }
}
