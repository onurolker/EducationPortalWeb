using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationPortal.Migrations
{
    public partial class EducatorType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EducatorType",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducatorType",
                table: "AspNetUsers");
        }
    }
}
