using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaComercioLibrary.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Parcela",
                table: "FormaPagamento",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Salario",
                table: "Adm",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parcela",
                table: "FormaPagamento");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Adm");
        }
    }
}
