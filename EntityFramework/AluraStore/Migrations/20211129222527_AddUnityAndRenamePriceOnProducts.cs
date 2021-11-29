using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraStore.Migrations
{
    public partial class AddUnityAndRenamePriceOnProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "UnitPrice");

            migrationBuilder.AddColumn<string>(
                name: "Unity",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unity",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Products",
                newName: "Price");
        }
    }
}
