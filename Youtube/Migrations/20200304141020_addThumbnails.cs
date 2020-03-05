using Microsoft.EntityFrameworkCore.Migrations;

namespace Youtube.Migrations
{
    public partial class addThumbnails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Thumbnails",
                table: "YoutubeResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnails",
                table: "YoutubeResults");
        }
    }
}
