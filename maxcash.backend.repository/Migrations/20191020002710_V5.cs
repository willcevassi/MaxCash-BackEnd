using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescricaoTipoConta",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescricaoTipoConta",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                nullable: true);
        }
    }
}
