using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoGameList.Migrations
{
    public partial class ESRB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ESRBId",
                table: "Games",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ESRB",
                columns: table => new
                {
                    ESRBId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESRB", x => x.ESRBId);
                });

            migrationBuilder.InsertData(
                table: "ESRB",
                columns: new[] { "ESRBId", "Name" },
                values: new object[,]
                {
                    {"E", "Everyone"},
                    {"E 10+", "Everyone 10+"},
                    {"T", "Teen"},
                    {"M", "Mature"},
                    {"A", "Adults" },
                    {"RP", "Rating Pending"}
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "VideoGameId",
                keyValue: 1,
                column: "ESRBId",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "VideoGameId",
                keyValue: 2,
                column: "ESRBId",
                value: "M");


            migrationBuilder.CreateIndex(
                name: "IX_Games_ESRBId",
                table: "Games",
                column: "ESRBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_ESRB_ESRBId",
                table: "Games",
                column: "ESRBId",
                principalTable: "ESRB",
                principalColumn: "ESRBId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_ESRB_ESRBId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "ESRB");

            migrationBuilder.DropIndex(
                name: "IX_Games_ESRBId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ESRBId",
                table: "Games");
        }
    }
}
