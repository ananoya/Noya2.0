using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context: DbContext
    {
        //Esta clase context hereda de DbContext
         
            //inicializo la conexion
            private string conexion = "Data Source=ANA_NOYA\\SQLEXPRESS;Initial Catalog=SistamaCuentaCorriente;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False";

            //data set
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<CuentaCorriente> CuentaCorrientes { get; set; }
            public DbSet<Movimiento> Movimentos { get; set; }

            //cuando EF necesita conectarse, usa conexion y UseSqlServer
            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer(conexion);

        
    }
}
