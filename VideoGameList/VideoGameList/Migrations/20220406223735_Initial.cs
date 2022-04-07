using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace VideoGameList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    VideoGameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    ReleaseDate = table.Column<DateTime?>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.VideoGameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "VideoGameId", "Title","Genre", "ReleaseDate","Rating" },
                values: new object[] { 1, "Tom Clancy's The Division 2", "Action RPG", new DateTime(2019, 3, 15), 5 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "VideoGameId", "Title", "Genre", "ReleaseDate", "Rating" },
                values: new object[] { 2, "Grand Theft Auto V", "Action Adventure", new DateTime(2013, 9, 17), 5 });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
