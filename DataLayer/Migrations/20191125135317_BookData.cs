using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class BookData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Barcode", "BorrowedDate", "Description", "Title", "UserFk", "UserId" },
                values: new object[] { 1, "Harper Lee", "1234", null, "Lorem ipsum", "To Kill A Mockingbird", null, null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Barcode", "BorrowedDate", "Description", "Title", "UserFk", "UserId" },
                values: new object[] { 2, "J. K. Rowling", "4312", null, "Lorem ipsum", "Harry Potter", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Barcode",
                table: "Books",
                column: "Barcode",
                unique: true,
                filter: "[Barcode] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_Barcode",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
