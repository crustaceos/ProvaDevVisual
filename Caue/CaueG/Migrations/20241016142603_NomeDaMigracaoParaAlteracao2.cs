using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaueG.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigracaoParaAlteracao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImpostoFgts",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "ImpostoInss",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "ImpostoIrrf",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
                table: "Folhas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ImpostoFgts",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoInss",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoIrrf",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioLiquido",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
