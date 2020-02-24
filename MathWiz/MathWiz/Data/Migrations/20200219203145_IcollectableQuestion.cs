using Microsoft.EntityFrameworkCore.Migrations;

namespace MathWiz.Data.Migrations
{
    public partial class IcollectableQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "Test");

            migrationBuilder.AddColumn<int>(
                name: "TestID",
                table: "Question",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_TestID",
                table: "Question",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Test_TestID",
                table: "Question",
                column: "TestID",
                principalTable: "Test",
                principalColumn: "TestID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Test_TestID",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_TestID",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "TestID",
                table: "Question");

            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "Test",
                nullable: false,
                defaultValue: 0);
        }
    }
}
