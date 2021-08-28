using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRSDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ProductName" },
                values: new object[] { 1, "Demo Product Description 1", "Demo Product 1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ProductName" },
                values: new object[] { 2, "Demo Product Description 2", "Demo Product 2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ProductName" },
                values: new object[] { 3, "Demo Product Description 3", "Demo Product 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
