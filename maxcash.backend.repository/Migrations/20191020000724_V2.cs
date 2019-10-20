using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTAS_UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                column: "UsuarioId",
                principalSchema: "DB_MAXCASH",
                principalTable: "TB_USUARIOS",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_CONTAS_UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");
        }
    }
}
