using ProyectMobilBD.Models;
using ProyectMobilBD.Utilidades;
using Microsoft.EntityFrameworkCore;

namespace ProyectMobilBD.DataAccess
{
    public class EmpleadoDbContext : DbContext
    {
        public DbSet<Empleados> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDB = $"Filename={ConexionDB.DevolverRuta("empleados.db")}";
            optionsBuilder.UseSqlite(conexionDB);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.ToTable("Empleados");
                entity.HasKey(e => e.IdEmpleado);
                entity.Property(e => e.IdEmpleado).IsRequired().ValueGeneratedOnAdd();

            });
        }

    }
}
