using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaueG.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigracaoParaAlteracao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalarioBruto",
                table: "Folhas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SalarioBruto",
                table: "Folhas",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
