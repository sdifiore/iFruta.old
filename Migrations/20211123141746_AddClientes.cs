using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iFruta.Migrations
{
    public partial class AddClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClienteId",
                table: "Produtos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ClienteId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Produtos");
        }
    }
}
