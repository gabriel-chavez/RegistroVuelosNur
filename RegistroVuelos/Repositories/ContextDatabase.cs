using Microsoft.EntityFrameworkCore;
using RegistroVuelos.Models;

namespace RegistroVuelos.Repositories
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
        }
        public DbSet<Vuelo> Vuelo { get; set; }
        public DbSet<Tripulacion> Tripulacion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vuelo>().ToTable("Vuelo");
            modelBuilder.Entity<Tripulacion>().ToTable("Tripulacion");
        }
    }
}
