using AvaluoInmobiliario.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AvaluoInmobiliario.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Avaluo> Avaluos { get; set; }
        public DbSet<AvaluoArchivo> AvaluoArchivos { get; set; }
        public DbSet<AvaluoEstatus> AvaluoEstatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add seed data for AvaluoEstatus
            modelBuilder.Entity<AvaluoEstatus>().HasData(
                new AvaluoEstatus { Id = 1, Descripcion = "Nuevo" },
                new AvaluoEstatus { Id = 2, Descripcion = "En proceso" },
                new AvaluoEstatus { Id = 3, Descripcion = "Completado" }
            );
        }
    }
}