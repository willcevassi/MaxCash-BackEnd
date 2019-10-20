using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class V8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SALDO_CONTA",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SALDO_CONTA",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");
        }
    }
}
