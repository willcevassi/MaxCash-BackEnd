using System;
using JetBrains.Annotations;
using maxcash.backend.model.entidades;
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

        protected MaxCashDbContext()
        {

        }
    }
}
