﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using maxcash.backend.repository.contexto;

namespace maxcash.backend.repository.Migrations
{
    [DbContext(typeof(MaxCashDbContext))]
    [Migration("20191020003153_V7")]
    partial class V7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("DB_MAXCASH")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("maxcash.backend.model.entidades.Conta", b =>
                {
                    b.Property<int>("ContaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_CONTA")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .HasColumnName("COR_CONTA");

                    b.Property<bool>("ExibirNoDashBoard")
                        .HasColumnName("EXIBIR_CONTA_DASH");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("NOME_CONTA")
                        .HasMaxLength(128);

                    b.Property<decimal>("Saldo")
                        .HasColumnName("SALDO_CONTA");

                    b.Property<int>("TipoConta")
                        .HasColumnName("TIPO_CONTA");

                    b.Property<int>("UsuarioId")
                        .HasColumnName("ID_USUARIO");

                    b.HasKey("ContaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_CONTAS");
                });

            modelBuilder.Entity("maxcash.backend.model.entidades.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_USUARIO")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("NASCIMENTO_USUARIO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMAIL_USUARIO")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("NOME_USUARIO")
                        .HasMaxLength(128);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("SENHA_USUARIO")
                        .HasMaxLength(480);

                    b.Property<string>("Situacao")
                        .HasColumnName("SITUACAO_USUARIO");

                    b.HasKey("UsuarioId");

                    b.ToTable("TB_USUARIOS");
                });

            modelBuilder.Entity("maxcash.backend.model.entidades.Conta", b =>
                {
                    b.HasOne("maxcash.backend.model.entidades.Usuario", "Usuario")
                        .WithMany("Contas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}