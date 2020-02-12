using Microsoft.EntityFrameworkCore.Migrations;

namespace MathWiz.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Grade",
                table: "Test",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "Test",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Test",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Test");
        }
    }
}
