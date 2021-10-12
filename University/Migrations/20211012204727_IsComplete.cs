using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations
{
    public partial class IsComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "CourseStudent",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "CourseStudent");
        }
    }
}
