using Microsoft.EntityFrameworkCore.Migrations;

namespace ItemStore.UI.Migrations.SqlServerMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Uprice = table.Column<decimal>(nullable: false),
                    Tprice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
