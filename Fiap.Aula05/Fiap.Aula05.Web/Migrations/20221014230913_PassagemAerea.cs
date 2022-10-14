using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Aula05.Web.Migrations
{
    public partial class PassagemAerea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    PassagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarifa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VooId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.PassagemId);
                    table.ForeignKey(
                        name: "FK_Passagens_Tbl_Voo_VooId",
                        column: x => x.VooId,
                        principalTable: "Tbl_Voo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_VooId",
                table: "Passagens",
                column: "VooId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passagens");
        }
    }
}
