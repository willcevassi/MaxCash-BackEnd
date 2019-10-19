using System;
using maxcash.backend.model.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace maxcash.backend.repository.mapeamentos
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("TB_CONTAS");
            builder.HasKey(c => c.ContaId);
            builder.Property(c => c.ContaId).UseMySqlIdentityColumn().HasColumnName("ID_CONTA");
            builder.Property(c => c.Nome).HasColumnName("NOME_CONTA").HasMaxLength(128).IsRequired();
        }
    }
}
