using Microsoft.EntityFrameworkCore.Migrations;

namespace Youtube.Migrations
{
    public partial class YoutubeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChannelId",
                table: "YoutubeResults");

            migrationBuilder.AddColumn<string>(
                name: "YoutubeId",
                table: "YoutubeResults",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YoutubeId",
                table: "YoutubeResults");

            migrationBuilder.AddColumn<string>(
                name: "ChannelId",
                table: "YoutubeResults",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
