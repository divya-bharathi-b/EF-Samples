using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codefirst_sample.Migrations
{
    public partial class authorclass_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author_Details",
                columns: table => new
                {
                    authorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    authorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneno = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author_Details", x => x.authorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Author_Details");
        }
    }
}
