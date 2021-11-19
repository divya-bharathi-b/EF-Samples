﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codefirst_sample.Migrations
{
    public partial class author_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "author",
                table: "books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "author",
                table: "books");
        }
    }
}
