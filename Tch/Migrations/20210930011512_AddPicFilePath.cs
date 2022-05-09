using Microsoft.EntityFrameworkCore.Migrations;

namespace Tch.Migrations
{
    public partial class AddPicFilePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureFileName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureFileName",
                table: "Users");
        }
    }
}
