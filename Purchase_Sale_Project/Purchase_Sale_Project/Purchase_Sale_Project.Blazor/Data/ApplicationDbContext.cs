using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Purchase_Sale_Project.Blazor.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuarios,IdentityRole<int>,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        //public DbSet<Productos> Productos { get; set; }
        //public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        //public DbSet<Ventas> Ventas { get; set; }
        //public DbSet<Compras> Compras { get; set; }
        //public DbSet<VentasDetalle> VentasDetalle { get; set; }
        //public DbSet<ComprasDetalle> ComprasDetalle { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Usuarios>().HasKey(u => u.Id);

        //    modelBuilder.Entity<Clientes>()
        //        .HasOne<Usuarios>(s => s.usuarios)
        //        .WithMany(s => s.Clientes)
        //        .HasForeignKey(s => s.UsuarioId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    //modelBuilder.Entity<Categorias>()
        //    //    .HasOne<Usuarios>(s => s.usuario)
        //}
    }
}
