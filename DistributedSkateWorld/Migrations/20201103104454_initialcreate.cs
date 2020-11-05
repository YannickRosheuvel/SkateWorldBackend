using Microsoft.EntityFrameworkCore.Migrations;

namespace DistributedSkateWorld.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Comment",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Content = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Comment", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Username = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        FirstName = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        LastName = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        Adres = table.Column<string>(maxLength: 50, nullable: true),
            //        Paswword = table.Column<string>(nullable: true),
            //        Email = table.Column<string>(maxLength: 50, nullable: true),
            //        XP = table.Column<decimal>(type: "money", nullable: false),
            //        Level = table.Column<int>(nullable: false),
            //        Rank = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Course",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(maxLength: 50, nullable: true),
            //        CourseToughness = table.Column<int>(nullable: false),
            //        Completed = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Course", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Course_User",
            //            column: x => x.ID,
            //            principalTable: "User",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Trick",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VideoPath = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        TrickName = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
            //        CourseId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Trick", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Trick_Course_CourseId",
            //            column: x => x.CourseId,
            //            principalTable: "Course",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Trick_Course",
            //            column: x => x.ID,
            //            principalTable: "Course",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Trick_CourseId",
            //    table: "Trick",
            //    column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Comment");

            //migrationBuilder.DropTable(
            //    name: "Trick");

            //migrationBuilder.DropTable(
            //    name: "Course");

            //migrationBuilder.DropTable(
            //    name: "User");
        }
    }
}
