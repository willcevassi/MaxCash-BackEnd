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
            builder.Ignore(c => c.DescricaoTipoConta);
            builder.Property(c => c.ContaId).UseMySqlIdentityColumn().HasColumnName("ID_CONTA");
            builder.Property(c => c.Nome).HasColumnName("NOME_CONTA").HasMaxLength(128).IsRequired();
            builder.Property(c => c.TipoConta).HasColumnName("TIPO_CONTA");
            builder.Property(c => c.UsuarioId).HasColumnName("ID_USUARIO").IsRequired().HasColumnType("int");
            builder.Property(c => c.Saldo).HasColumnName("SALDO_CONTA").HasColumnType("decimal(5,2)");
            builder.Property(c => c.Cor).HasColumnName("COR_CONTA").HasMaxLength(30);
            builder.Property(c => c.ExibirNoDashBoard).HasColumnName("EXIBIR_CONTA_DASH");
        }
    }
}
