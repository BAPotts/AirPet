using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPet.Migrations
{
    public partial class MyUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "MyUserInfoId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MyUserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Pets = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyUserInfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MyUserInfoId",
                table: "AspNetUsers",
                column: "MyUserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MyUserInfo_MyUserInfoId",
                table: "AspNetUsers",
                column: "MyUserInfoId",
                principalTable: "MyUserInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MyUserInfo_MyUserInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MyUserInfo");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MyUserInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MyUserInfoId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
