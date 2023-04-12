using Microsoft.EntityFrameworkCore;
using ServidorCliMAUI.Models;

namespace ServidorCliMAUI.Contenido
{
    public class AppDbContext : DbContext
    {
        public DbSet<Plato> Platos => Set<Plato>();
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op)
        {

        }
    }
}
