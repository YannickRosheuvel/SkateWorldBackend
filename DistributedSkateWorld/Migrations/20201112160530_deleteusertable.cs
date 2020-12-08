using Microsoft.EntityFrameworkCore.Migrations;

namespace DistributedSkateWorld.Migrations
{
    public partial class deleteusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "User",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
