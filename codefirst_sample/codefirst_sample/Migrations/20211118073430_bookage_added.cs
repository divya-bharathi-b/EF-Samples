using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codefirst_sample.Migrations
{
    public partial class bookage_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book_Age",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book_Age",
                table: "books");
        }
    }
}
