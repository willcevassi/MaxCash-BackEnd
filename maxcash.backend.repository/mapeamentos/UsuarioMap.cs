using System;
using maxcash.backend.model.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace maxcash.backend.repository.mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_USUARIOS");
            builder.HasKey(u => u.UsuarioId);
            builder.Property(u => u.UsuarioId).UseMySqlIdentityColumn().HasColumnName("ID_USUARIO");
            builder.Property(u => u.Nome).HasColumnName("NOME_USUARIO").HasMaxLength(128).IsRequired();
            builder.Property(u => u.Email).HasColumnName("EMAIL_USUARIO").HasMaxLength(100).IsRequired();
            builder.Property(u => u.DataNascimento).HasColumnName("NASCIMENTO_USUARIO");
            builder.Property(u => u.Senha).HasColumnName("SENHA_USUARIO").HasMaxLength(480).IsRequired();
            builder.Property(u => u.Situacao).HasColumnName("SITUACAO_USUARIO");
            builder.HasMany(u => u.Contas).WithOne(c => c.Usuario).HasForeignKey(c => c.UsuarioId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
