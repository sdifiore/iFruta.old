using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iFruta.Migrations
{
    public partial class AddOneProdutosToManyCategoriasRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriasId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Categorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriasId",
                table: "Produtos",
                column: "CategoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_CategoriaId",
                table: "Categorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Categorias_CategoriaId",
                table: "Categorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriasId",
                table: "Produtos",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Categorias_CategoriaId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriasId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoriasId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_CategoriaId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CategoriasId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Categorias");
        }
    }
}
