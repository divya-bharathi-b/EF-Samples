using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp01.Migrations
{
    public partial class ts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Timesheet",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empid = table.Column<int>(type: "int", nullable: false),
                    empname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    changedate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    task = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheet", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timesheet");
        }
    }
}
