using Entidades;
using Modelo;

namespace Controladora
{
    public class Controladora
    {

        //patron singelton-- tenga una única instancia

        private Repositorio repositorio = new Repositorio();

        private static Controladora instancia;
        public static Controladora Instancia
        {
            get
            {
                if (instancia == null) //si no existe una instancia de la clase Controladora, la crea
                {
                    return instancia = new Controladora();
                }

                return instancia; // si ya existe una instancia, la devuelve
            }
        }



        public IReadOnlyCollection<Socio> ListarSocios()
        {
            return repositorio.ListarSocios();
        }

        public IReadOnlyCollection<Prestamo> ListarPrestamosActivos()
        {
            return repositorio.ListarPrestamosActivos();
        }

        public IReadOnlyCollection<Libro> ListarLibro()
        {
            return repositorio.ListarLibros();
        }

        
        public IReadOnlyCollection<Prestamo> ListarHistorialPrestamos()
        {
            return repositorio.ListarHistorialPrestamos();
        }

        public void AgregarLibro(Libro libro)
        {
            try
            {
                repositorio.AgregarLibro(libro);
            }catch (Exception e) {
                throw new Exception("Error +"); 
            }
        }

    }
}
