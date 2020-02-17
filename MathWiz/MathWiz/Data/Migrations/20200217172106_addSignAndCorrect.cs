using Microsoft.EntityFrameworkCore.Migrations;

namespace MathWiz.Data.Migrations
{
    public partial class addSignAndCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Correct",
                table: "Question",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Sign",
                table: "Question",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Correct",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Sign",
                table: "Question");
        }
    }
}
