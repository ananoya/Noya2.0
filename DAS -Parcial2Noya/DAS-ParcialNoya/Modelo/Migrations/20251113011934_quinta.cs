using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class quinta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubtipoCredito",
                table: "Movimentos");

            migrationBuilder.DropColumn(
                name: "SubtipoDebito",
                table: "Movimentos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubtipoCredito",
                table: "Movimentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubtipoDebito",
                table: "Movimentos",
                type: "int",
                nullable: true);
        }
    }
}
