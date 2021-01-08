using Microsoft.EntityFrameworkCore.Migrations;

namespace DistributedSkateWorld.Migrations
{
    public partial class mtmr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Course_User",
                table: "Course",
                column: "ID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
