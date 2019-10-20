using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class V9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "COR_CONTA",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "COR_CONTA",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
