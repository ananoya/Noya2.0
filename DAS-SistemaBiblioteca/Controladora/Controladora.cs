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
            try
            {
               return repositorio.ListarSocios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar socios"+ ex);
            }
            
        }

        public IReadOnlyCollection<Prestamo> ListarPrestamosActivos()
        {
            try
            {
                return repositorio.ListarPrestamosActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar prestamos activos" + ex);
            }
            
        }

        public IReadOnlyCollection<Libro> ListarLibro()
        {
            try
            {
                return repositorio.ListarLibros();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar libros" + ex);
            }
        }
        
        public IReadOnlyCollection<Prestamo> ListarHistorialPrestamos()
        {   try
            {
                return repositorio.ListarHistorialPrestamos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Historial de prestamos" + ex);
            }
        }

        public void AgregarLibro(Libro libro)
        {
            try
            {
                repositorio.AgregarLibro(libro);
            }
            catch (Exception ex) {
                throw new Exception("Error al agregar libro" + ex);           
            }
        } 

        public void ModificarLibro(Libro libro)
        {
            try
            {
                repositorio.Modificar(libro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar libro" + ex);
            }
        }

        public void EliminarLibro(Libro libro)
        {
            try
            {
                repositorio.Eliminar(libro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar libro" + ex);
            }
        }

        public void AgregarSocio(Socio socio)
        {
            try
            {
                repositorio.AgregarSocio(socio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar socio" + ex);
            }
        }
       
        public void ModificarSocio(Socio socio)
        {
            try
            {
                repositorio.Modificar(socio);
            }
            catch(Exception ex)
            {
                throw new Exception("Error al modificar socio" + ex);
            }

        }

        public void EliminarSocio(Socio socio)
        {
            try
            {
                repositorio.Eliminar(socio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar libros" + ex);
            }
        }

        public void RegistrarPrestamo(string isbn, string dniSocio)
        {
            try
            {
                repositorio.RegistrarPrestamo(isbn, dniSocio);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar prestamos" + ex);
            }
        }

        public void RegistrarDevolucion(int idPrestamo)
        {
            try
            {
                repositorio.RegistrarDevolucion(idPrestamo);
            }
            catch(Exception ex)
            {
                throw new Exception("Error al registrar la devolución" + ex);
            }
        }

        public void ModificarPrestamo(Prestamo prestamo)
        {
            try
            {
                repositorio.ModificarPrestamo(prestamo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar prestamo" + ex);
            }
        }

    }
}
