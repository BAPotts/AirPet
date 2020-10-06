using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirPet.Migrations
{
    public partial class Profile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MyUserInfo_MyUserInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MyUserInfo");

            migrationBuilder.RenameColumn(
                name: "MyUserInfoId",
                table: "AspNetUsers",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_MyUserInfoId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ProfileId");

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Pets = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ProfileId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Profile_ProfileId",
                table: "AspNetUsers",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Profile_ProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "AspNetUsers",
                newName: "MyUserInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ProfileId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_MyUserInfoId");

            migrationBuilder.CreateTable(
                name: "MyUserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Bio = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Pets = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyUserInfo", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MyUserInfo_MyUserInfoId",
                table: "AspNetUsers",
                column: "MyUserInfoId",
                principalTable: "MyUserInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
