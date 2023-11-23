using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestivalCartage.Migrations
{
    public partial class artistNameAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "artistName",
                table: "Concert",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "artistName",
                table: "Concert");
        }
    }
}
