using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCBookstore.Migrations
{
    public partial class UpdateBookTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Publisher",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<short>(
                name: "Pages",
                table: "Books",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Pages",
                table: "Books",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
