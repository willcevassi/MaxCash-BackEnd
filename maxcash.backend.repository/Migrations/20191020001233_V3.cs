using Microsoft.EntityFrameworkCore.Migrations;

namespace maxcash.backend.repository.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "USUARIO_ID");

            migrationBuilder.RenameColumn(
                name: "TipoConta",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "TIPO_CONTA");

            migrationBuilder.RenameColumn(
                name: "Saldo",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "SALDO_CONTA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTAS_UsuarioId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CONTAS_TB_USUARIOS_USUARIO_ID",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS");

            migrationBuilder.RenameColumn(
                name: "USUARIO_ID",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "TIPO_CONTA",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "TipoConta");

            migrationBuilder.RenameColumn(
                name: "SALDO_CONTA",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "Saldo");

            migrationBuilder.RenameIndex(
                name: "IX_TB_CONTAS_USUARIO_ID",
                schema: "DB_MAXCASH",
                table: "TB_CONTAS",
                newName: "IX_TB_CONTAS_UsuarioId");

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
    }
}
