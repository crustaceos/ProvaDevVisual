using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaueG.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigracaoParaAlteracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorasTrabalhadas",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "ValorHora",
                table: "Funcionarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HorasTrabalhadas",
                table: "Funcionarios",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ValorHora",
                table: "Funcionarios",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
