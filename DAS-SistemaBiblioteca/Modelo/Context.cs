using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    //Esta clase context hereda de DbContext
    public class Context : DbContext
    {
        //inicializo la conexion
        private string conexion = "Data Source=ANA_NOYA\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False";

        //data set
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        //cuando EF necesita conectarse, usa conexion y UseSqlServer
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);

    }
}
