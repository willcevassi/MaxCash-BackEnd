using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class PrimeiraVersao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DB_MAXCASH");

            migrationBuilder.CreateTable(
                name: "TB_CONTAS",
                schema: "DB_MAXCASH",
                columns: table => new
                {
                    ID_CONTA = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME_CONTA = table.Column<string>(maxLength: 128, nullable: false),
                    Saldo = table.Column<decimal>(nullable: false),
                    Cor = table.Column<string>(nullable: true),
                    TipoConta = table.Column<int>(nullable: false),
                    DescricaoTipoConta = table.Column<string>(nullable: true),
                    AdicionaDashBoard = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTAS", x => x.ID_CONTA);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                schema: "DB_MAXCASH",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EMAIL_USUARIO = table.Column<string>(maxLength: 100, nullable: false),
                    NOME_USUARIO = table.Column<string>(maxLength: 128, nullable: false),
                    NASCIMENTO_USUARIO = table.Column<DateTime>(nullable: false),
                    SENHA_USUARIO = table.Column<string>(maxLength: 480, nullable: false),
                    SITUACAO_USUARIO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.ID_USUARIO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CONTAS",
                schema: "DB_MAXCASH");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS",
                schema: "DB_MAXCASH");
        }
    }
}
