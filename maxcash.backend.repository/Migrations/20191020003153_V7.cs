using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_USUARIO_ID",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");

            migrationBuilder.RenameColumn(
                name: "USUARIO_ID",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "ID_USUARIO");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTAS_USUARIO_ID",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "IX_TB_CONTAS_ID_USUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_ID_USUARIO",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                column: "ID_USUARIO",
                principalSchema: "DB_MAXCASH",
                principalTable: "TB_USUARIOS",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_ID_USUARIO",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");

            migrationBuilder.RenameColumn(
                name: "ID_USUARIO",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "USUARIO_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTAS_ID_USUARIO",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "IX_TB_CONTAS_USUARIO_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_USUARIO_ID",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                column: "USUARIO_ID",
                principalSchema: "DB_MAXCASH",
                principalTable: "TB_USUARIOS",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
