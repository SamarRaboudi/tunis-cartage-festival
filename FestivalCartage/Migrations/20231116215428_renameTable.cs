using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestivalCartage.Migrations
{
    public partial class renameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Concert");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concert",
                table: "Concert",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Concert",
                table: "Concert");

            migrationBuilder.RenameTable(
                name: "Concert",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "id");
        }
    }
}
