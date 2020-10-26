using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoIntegrador.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descricao_categoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    qtd_entrada = table.Column<int>(nullable: false),
                    qtd_saida = table.Column<int>(nullable: false),
                    qtd_estoque_atual = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    razao_social = table.Column<string>(nullable: true),
                    cnpj = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    rua = table.Column<string>(nullable: true),
                    cep = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data = table.Column<DateTime>(nullable: false),
                    cpf_comprador = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_usuario = table.Column<int>(nullable: false),
                    total = table.Column<decimal>(nullable: false),
                    data = table.Column<DateTime>(nullable: false),
                    id_notafiscal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_produto = table.Column<int>(nullable: false),
                    id_pedido = table.Column<int>(nullable: false),
                    preco_unitario_produto = table.Column<decimal>(nullable: false),
                    preco_total_produto = table.Column<decimal>(nullable: false),
                    quantidade_produto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoPedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    Categoria = table.Column<string>(nullable: false),
                    Fornecedor = table.Column<string>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: false),
                    Confirmarsenha = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Fornecedors");

            migrationBuilder.DropTable(
                name: "NotaFiscals");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "ProdutoPedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
