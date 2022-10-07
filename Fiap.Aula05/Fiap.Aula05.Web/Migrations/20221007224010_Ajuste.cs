using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Aula05.Web.Migrations
{
    public partial class Ajuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Voos",
                table: "Voos");

            migrationBuilder.RenameTable(
                name: "Voos",
                newName: "Tbl_Voo");

            migrationBuilder.RenameColumn(
                name: "VooId",
                table: "Tbl_Voo",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Origem",
                table: "Tbl_Voo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Destino",
                table: "Tbl_Voo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Voo",
                table: "Tbl_Voo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Voo",
                table: "Tbl_Voo");

            migrationBuilder.RenameTable(
                name: "Tbl_Voo",
                newName: "Voos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Voos",
                newName: "VooId");

            migrationBuilder.AlterColumn<string>(
                name: "Origem",
                table: "Voos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Destino",
                table: "Voos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voos",
                table: "Voos",
                column: "VooId");
        }
    }
}
