using Microsoft.EntityFrameworkCore;
using MonsBarberStudio.Models;


namespace MonsBarberStudio.Data
{
    public class Context : DbContext
    {
        //contrustor 
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        public DbSet<Roles> rols { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
