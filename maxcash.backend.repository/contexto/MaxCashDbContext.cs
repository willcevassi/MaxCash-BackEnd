using System;
using JetBrains.Annotations;
using maxcash.backend.model.entidades;
using maxcash.backend.repository.mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace maxcash.backend.repository.contexto
{
    public class MaxCashDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Conta> Contas { get; set; }
     
        public MaxCashDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=10.1.1.105;Database=DB_MAXCASH;Uid=sa;Pwd=M@ster123;";
            optionsBuilder.UseLazyLoadingProxies().UseMySql(connectionString, m => m.MigrationsAssembly("maxcash.backend.repository"));
        }

        public MaxCashDbContext(){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DB_MAXCASH");
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ContaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
