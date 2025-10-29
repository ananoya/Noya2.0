using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Repositorio
    {
        private Context context;

        public Repositorio()
        {
            context = new Context();
        }

        //Gestión de alta, baja y modificación de libros
        //Metodo Listar Libros
        public IReadOnlyCollection<Libro> ListarLibros()
        {
            return context.Libros.ToList().AsReadOnly(); //libros nombre de la tabla en bdd
        }
        //Metodo Agregar Libro
        public void AgregarLibro(Libro libro)
        {
            context.Libros.Add(libro);
            context.SaveChanges();
        }
        //Metodo Modificar Libro
        public void Modificar(Libro libro)
        {
            context.Libros.Update(libro);
            context.SaveChanges();
        }
        //Metodo Eliminar libro
        public void Eliminar(Libro libro)
        {
            context.Libros.Remove(libro);
            context.SaveChanges();
        }

        //Gestión de alta, baja y modificación de socios
        //Metodo Listar Socios
        public IReadOnlyCollection<Socio> ListarSocios()
        {
            return context.Socios.ToList().AsReadOnly();
        }
        //Metodo Agregar Socio
        public void AgregarSocio(Socio socio)
        {
            context.Socios.Add(socio);
            context.SaveChanges();
        }
        //Metodo Modificar Socio
        public void Modificar(Socio socio)
        {
            context.Socios.Update(socio);
            context.SaveChanges();
        }
        //Metodo Eliminar Socio
        public void Eliminar(Socio socio)
        {
            context.Socios.Remove(socio);
            context.SaveChanges();
        }


        //Registrar préstamos(verificar que el libro esté disponible)
        //Aparezca en el data gried los prestamos activos
      
        //Metodo registrar prestamo 
        public void RegistrarPrestamo(string isbn, string dniSocio)
        {
            var libro = context.Libros.Find(isbn);

            //validar si el libro existe y esta disponible
            if (libro == null)
            {
                throw new Exception("El libro no existe.");
            }
            
            if (libro.Estado == EstadoLibro.Prestado)
            {
                throw new Exception("El libro ya está prestado.");
            }
            
            //validar si el socio existe
            var socio = context.Socios.FirstOrDefault(s => s.Dni == dniSocio);

            if (socio == null) 
            { 
                throw new Exception("El socio no existe."); 
            }

            //Crear un nuevo Prestamo y asociarle el libro y socio.
            var prestamo = new Prestamo
            {
                LibroAsociado = libro,
                SocioAsociado = socio,
                FechaPrestamo = DateTime.Now
            };

            //luego de validar agrego a la tabla prestamos
            context.Prestamos.Add(prestamo);
            libro.Estado = EstadoLibro.Prestado;
            context.SaveChanges();
        }

        //Metodo listar prestamo activos (enum = prestado)
        public IReadOnlyCollection<Prestamo> ListarPrestamosActivos()
        { 
            return context.Prestamos
                .Where(p => p.LibroAsociado.Estado == EstadoLibro.Prestado)
                .Include(p => p.LibroAsociado) // carga el libro junto al préstamo
                .Include(p => p.SocioAsociado) // carga el socio junto al préstamo
                .ToList().AsReadOnly();
        }

        //Registrar (cambia de estado) devoluciones de libros (modificacion del estado nada mas)
        /*Buscar el préstamo por su ID.

        Cambiar la FechaDevolucion.

        Cambiar el estado del libro a Disponible.

        Guardar cambios.*/
        public void RegistrarDevolucion(int idPrestamo)
        {
            //busco el prestamo por id
            var prestamo = context.Prestamos
           .Include(p => p.LibroAsociado)
           .FirstOrDefault(p => p.IdPrestamo == idPrestamo);

            //valido si existe
            if (prestamo == null)
            {
                throw new Exception("El préstamo no existe.");
            }

            //actualizo fecha de devolucion y cambio estado
            prestamo.FechaDevolucion = DateTime.Now;
            prestamo.LibroAsociado.Estado = EstadoLibro.Disponible;

            context.SaveChanges();
        }

        //Metodo Modificar prestamo (datos)
        public void ModificarPrestamo(Prestamo prestamo)
        {
            context.Prestamos.Update(prestamo);
            context.SaveChanges();
        }

        //historial de trasacciones (metodo a disponible a )
        //quiero poner todos los préstamos prestados y devueltos, o filtrados por socio, libro, fecha, etc. ;)))
        public IReadOnlyCollection<Prestamo> ListarHistorialPrestamos()
        {
            return context.Prestamos.Include(p=> p.LibroAsociado).Include(p => p.SocioAsociado).ToList().AsReadOnly();
        }

    }

}
