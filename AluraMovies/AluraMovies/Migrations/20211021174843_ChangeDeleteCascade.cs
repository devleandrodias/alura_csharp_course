using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraMovies.Migrations
{
    public partial class ChangeDeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTheaters_Managers_ManagerId",
                table: "MovieTheaters");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTheaters_Managers_ManagerId",
                table: "MovieTheaters",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieTheaters_Managers_ManagerId",
                table: "MovieTheaters");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieTheaters_Managers_ManagerId",
                table: "MovieTheaters",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
