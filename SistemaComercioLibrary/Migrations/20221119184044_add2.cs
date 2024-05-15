using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaComercioLibrary.Migrations
{
    public partial class add2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormaPagamento",
                table: "MovimentoCaixa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parcelamento",
                table: "MovimentoCaixa",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaPagamento",
                table: "MovimentoCaixa");

            migrationBuilder.DropColumn(
                name: "Parcelamento",
                table: "MovimentoCaixa");
        }
    }
}
