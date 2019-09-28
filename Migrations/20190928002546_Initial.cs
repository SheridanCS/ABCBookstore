using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCBookstore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Authors = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    Publisher = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    Pages = table.Column<short>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
