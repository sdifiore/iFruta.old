using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iFruta.Migrations
{
    public partial class UndoLastMigrationWithWrongRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Categorias_CategoriaId",
                table: "Categorias");

            migrationBuilder.DropTable(
                name: "PedidoProduto");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_CategoriaId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Categorias");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Categorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PedidoProduto",
                columns: table => new
                {
                    ProdutosId = table.Column<int>(type: "int", nullable: false),
                    ProdutosId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProduto", x => new { x.ProdutosId, x.ProdutosId1 });
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Pedidos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProduto_Produtos_ProdutosId1",
                        column: x => x.ProdutosId1,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_CategoriaId",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_ProdutosId1",
                table: "PedidoProduto",
                column: "ProdutosId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Categorias_CategoriaId",
                table: "Categorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }
    }
}
