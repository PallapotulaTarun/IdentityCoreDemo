using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityCoreDemo.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Charges",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TheatreName",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Charges",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TheatreName",
                table: "Movies");
        }
    }
}
