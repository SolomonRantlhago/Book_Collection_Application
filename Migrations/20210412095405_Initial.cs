using Microsoft.EntityFrameworkCore.Migrations;

namespace RantlhagoSM_Assign1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookTitle = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    BookAuthor = table.Column<string>(type: "TEXT", nullable: false),
                    BookISBN = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    BookIsRead = table.Column<string>(type: "TEXT", nullable: false)
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
