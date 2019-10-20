using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cor",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "COR_CONTA");

            migrationBuilder.RenameColumn(
                name: "AdicionaDashBoard",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "EXIBIR_CONTA_DASH");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "COR_CONTA",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "Cor");

            migrationBuilder.RenameColumn(
                name: "EXIBIR_CONTA_DASH",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "AdicionaDashBoard");
        }
    }
}
