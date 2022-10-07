using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Aula05.Web.Migrations
{
    public partial class RelacionamentoUmParaUm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FrequenciaVooId",
                table: "Tbl_Voo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tbl_Frequencia_Voo",
                columns: table => new
                {
                    FrequenciaVooId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoFrequencia = table.Column<int>(type: "int", nullable: false),
                    DataAtivacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Frequencia_Voo", x => x.FrequenciaVooId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Voo_FrequenciaVooId",
                table: "Tbl_Voo",
                column: "FrequenciaVooId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Voo_Tbl_Frequencia_Voo_FrequenciaVooId",
                table: "Tbl_Voo",
                column: "FrequenciaVooId",
                principalTable: "Tbl_Frequencia_Voo",
                principalColumn: "FrequenciaVooId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Voo_Tbl_Frequencia_Voo_FrequenciaVooId",
                table: "Tbl_Voo");

            migrationBuilder.DropTable(
                name: "Tbl_Frequencia_Voo");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Voo_FrequenciaVooId",
                table: "Tbl_Voo");

            migrationBuilder.DropColumn(
                name: "FrequenciaVooId",
                table: "Tbl_Voo");
        }
    }
}
