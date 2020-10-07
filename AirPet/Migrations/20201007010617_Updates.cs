using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPet.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Hosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pets",
                table: "Hosts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Hosts");

            migrationBuilder.DropColumn(
                name: "Pets",
                table: "Hosts");
        }
    }
}
