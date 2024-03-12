using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mission10_API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BowlerFirstName = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerMiddleInit = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerLastName = table.Column<string>(type: "TEXT", nullable: false),
                    TeamID = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamNameTeamID = table.Column<int>(type: "INTEGER", nullable: false),
                    BowlerAddress = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerCity = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerState = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerZip = table.Column<string>(type: "TEXT", nullable: false),
                    BowlerPhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerID);
                    table.ForeignKey(
                        name: "FK_Bowlers_Team_TeamNameTeamID",
                        column: x => x.TeamNameTeamID,
                        principalTable: "Team",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamID", "TeamName" },
                values: new object[,]
                {
                    { 1, "Marlins" },
                    { 2, "Sharks" },
                    { 3, "Terrapins" },
                    { 4, "Barracudas" },
                    { 5, "Dolphins" },
                    { 6, "Orcas" },
                    { 7, "Manatees" },
                    { 8, "Swordfish" },
                    { 9, "Huckleberrys" },
                    { 10, "MintJuleps" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bowlers_TeamNameTeamID",
                table: "Bowlers",
                column: "TeamNameTeamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
