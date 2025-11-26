using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentos_CuentaCorrientes_CuentaCorrienteId",
                table: "Movimentos");

            migrationBuilder.DropIndex(
                name: "IX_Movimentos_CuentaCorrienteId",
                table: "Movimentos");

            migrationBuilder.RenameColumn(
                name: "CuentaCorrienteId",
                table: "Movimentos",
                newName: "CuentaCorrienteAsociada");

            migrationBuilder.AddColumn<int>(
                name: "CuentaAsociadaCuentaCorrienteId",
                table: "Movimentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movimentos_CuentaAsociadaCuentaCorrienteId",
                table: "Movimentos",
                column: "CuentaAsociadaCuentaCorrienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentos_CuentaCorrientes_CuentaAsociadaCuentaCorrienteId",
                table: "Movimentos",
                column: "CuentaAsociadaCuentaCorrienteId",
                principalTable: "CuentaCorrientes",
                principalColumn: "CuentaCorrienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentos_CuentaCorrientes_CuentaAsociadaCuentaCorrienteId",
                table: "Movimentos");

            migrationBuilder.DropIndex(
                name: "IX_Movimentos_CuentaAsociadaCuentaCorrienteId",
                table: "Movimentos");

            migrationBuilder.DropColumn(
                name: "CuentaAsociadaCuentaCorrienteId",
                table: "Movimentos");

            migrationBuilder.RenameColumn(
                name: "CuentaCorrienteAsociada",
                table: "Movimentos",
                newName: "CuentaCorrienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentos_CuentaCorrienteId",
                table: "Movimentos",
                column: "CuentaCorrienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentos_CuentaCorrientes_CuentaCorrienteId",
                table: "Movimentos",
                column: "CuentaCorrienteId",
                principalTable: "CuentaCorrientes",
                principalColumn: "CuentaCorrienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
