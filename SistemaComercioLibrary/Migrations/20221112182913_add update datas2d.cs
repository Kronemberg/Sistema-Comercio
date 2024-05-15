using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SistemaComercioLibrary.Migrations
{
    public partial class addupdatedatas2d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Usuario = table.Column<string>(maxLength: 20, nullable: false),
                    Senha = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Saldo = table.Column<double>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Cpf_Cnpj = table.Column<string>(maxLength: 18, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 255, nullable: false),
                    Numero = table.Column<int>(maxLength: 4, nullable: false),
                    Complemento = table.Column<string>(maxLength: 255, nullable: false),
                    Bairro = table.Column<string>(maxLength: 255, nullable: false),
                    Cidade = table.Column<string>(maxLength: 255, nullable: false),
                    Estado = table.Column<string>(maxLength: 255, nullable: false),
                    Cep = table.Column<string>(maxLength: 9, nullable: false),
                    Telefone = table.Column<string>(maxLength: 13, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Cpf_Cnpj = table.Column<string>(maxLength: 18, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 255, nullable: false),
                    Numero = table.Column<string>(maxLength: 4, nullable: false),
                    Complemento = table.Column<string>(maxLength: 255, nullable: false),
                    Bairro = table.Column<string>(maxLength: 255, nullable: false),
                    Cidade = table.Column<string>(maxLength: 255, nullable: false),
                    Estado = table.Column<string>(maxLength: 255, nullable: false),
                    Cep = table.Column<string>(maxLength: 9, nullable: false),
                    Telefone = table.Column<string>(maxLength: 13, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovimentoCaixa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Data_Movimento = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Hora_Movimento = table.Column<DateTime>(maxLength: 5, nullable: false),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    Tipo_Movimento = table.Column<string>(maxLength: 255, nullable: false),
                    Valor = table.Column<double>(maxLength: 255, nullable: false),
                    Id_Caixa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentoCaixa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimentoCaixa_Caixa_Id_Caixa",
                        column: x => x.Id_Caixa,
                        principalTable: "Caixa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContaReceber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    Data_Lancamento = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Data_Vencimento = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Valor = table.Column<double>(maxLength: 255, nullable: false),
                    Recebido = table.Column<double>(maxLength: 255, nullable: false),
                    Data_Recebimento = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Valor_Recebimento = table.Column<double>(maxLength: 255, nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaReceber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaReceber_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Data = table.Column<string>(nullable: false),
                    Hora = table.Column<string>(nullable: false),
                    Total_Venda = table.Column<double>(maxLength: 255, nullable: false),
                    Situacao_Venda = table.Column<string>(maxLength: 255, nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venda_Cliente_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Data = table.Column<string>(maxLength: 255, nullable: false),
                    Hora = table.Column<string>(maxLength: 255, nullable: false),
                    Total_Compra = table.Column<double>(maxLength: 255, nullable: false),
                    Situacao_Compra = table.Column<string>(maxLength: 255, nullable: false),
                    Id_Fornecedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Fornecedor_Id_Fornecedor",
                        column: x => x.Id_Fornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContaPagar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    Data_Lancamento = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Data_Vencimento = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Valor = table.Column<double>(maxLength: 255, nullable: false),
                    Pago = table.Column<double>(maxLength: 255, nullable: false),
                    Data_Pagamento = table.Column<DateTime>(maxLength: 10, nullable: false),
                    Valor_Pagamento = table.Column<double>(maxLength: 255, nullable: false),
                    Id_Fornecedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaPagar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaPagar_Fornecedor_Id_Fornecedor",
                        column: x => x.Id_Fornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Quantidade_Estoque = table.Column<int>(maxLength: 255, nullable: false),
                    Preco = table.Column<double>(maxLength: 255, nullable: false),
                    Unidade = table.Column<string>(maxLength: 255, nullable: false),
                    Id_Fornecedor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Fornecedor_Id_Fornecedor",
                        column: x => x.Id_Fornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamentoVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valor = table.Column<double>(maxLength: 255, nullable: false),
                    Id_Venda = table.Column<int>(nullable: false),
                    Id_FormaPagamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamentoVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormaPagamentoVenda_FormaPagamento_Id_FormaPagamento",
                        column: x => x.Id_FormaPagamento,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormaPagamentoVenda_Venda_Id_Venda",
                        column: x => x.Id_Venda,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemCompra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantidade = table.Column<int>(maxLength: 255, nullable: false),
                    Valor_Unitario = table.Column<double>(maxLength: 255, nullable: false),
                    Total_Item = table.Column<double>(maxLength: 255, nullable: false),
                    Id_Produto = table.Column<int>(nullable: false),
                    Id_Compra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Compra_Id_Compra",
                        column: x => x.Id_Compra,
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemCompra_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemVenda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantidade = table.Column<int>(maxLength: 255, nullable: false),
                    Valor_Unitario = table.Column<double>(maxLength: 255, nullable: false),
                    Total_Item = table.Column<double>(maxLength: 255, nullable: false),
                    Id_Venda = table.Column<int>(nullable: false),
                    Id_Produto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Venda_Id_Venda",
                        column: x => x.Id_Venda,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_Id_Fornecedor",
                table: "Compra",
                column: "Id_Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_ContaPagar_Id_Fornecedor",
                table: "ContaPagar",
                column: "Id_Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_ContaReceber_Id_Cliente",
                table: "ContaReceber",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_FormaPagamentoVenda_Id_FormaPagamento",
                table: "FormaPagamentoVenda",
                column: "Id_FormaPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_FormaPagamentoVenda_Id_Venda",
                table: "FormaPagamentoVenda",
                column: "Id_Venda");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_Id_Compra",
                table: "ItemCompra",
                column: "Id_Compra");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCompra_Id_Produto",
                table: "ItemCompra",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_Id_Produto",
                table: "ItemVenda",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_Id_Venda",
                table: "ItemVenda",
                column: "Id_Venda");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentoCaixa_Id_Caixa",
                table: "MovimentoCaixa",
                column: "Id_Caixa");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Id_Fornecedor",
                table: "Produto",
                column: "Id_Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Id_Cliente",
                table: "Venda",
                column: "Id_Cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adm");

            migrationBuilder.DropTable(
                name: "ContaPagar");

            migrationBuilder.DropTable(
                name: "ContaReceber");

            migrationBuilder.DropTable(
                name: "FormaPagamentoVenda");

            migrationBuilder.DropTable(
                name: "ItemCompra");

            migrationBuilder.DropTable(
                name: "ItemVenda");

            migrationBuilder.DropTable(
                name: "MovimentoCaixa");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Caixa");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
