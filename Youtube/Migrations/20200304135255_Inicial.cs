using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Youtube.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YoutubeResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChannelId = table.Column<string>(nullable: true),
                    ChannelTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LiveBroadcastContent = table.Column<string>(nullable: true),
                    PublishedAtRaw = table.Column<string>(nullable: true),
                    PublishedAt = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    ETag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoutubeResults", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YoutubeResults");
        }
    }
}
