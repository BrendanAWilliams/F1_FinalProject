using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace F1_FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(maxLength: 60, nullable: false),
                    Base = table.Column<string>(maxLength: 60, nullable: true),
                    Chief = table.Column<string>(maxLength: 60, nullable: false),
                    Chasis = table.Column<string>(maxLength: 10, nullable: true),
                    PowerUnit = table.Column<string>(maxLength: 60, nullable: true),
                    FirstEntry = table.Column<int>(nullable: false),
                    Championships = table.Column<int>(nullable: false),
                    PolePositions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 60, nullable: false),
                    LastName = table.Column<string>(maxLength: 60, nullable: false),
                    Number = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Podiums = table.Column<int>(nullable: false),
                    Points = table.Column<double>(nullable: false),
                    GPEntered = table.Column<int>(nullable: false),
                    Championships = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverID);
                    table.ForeignKey(
                        name: "FK_Drivers_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    CircuitID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GPName = table.Column<string>(maxLength: 60, nullable: false),
                    CircuitName = table.Column<string>(maxLength: 60, nullable: false),
                    Location = table.Column<string>(maxLength: 60, nullable: true),
                    FirstGP = table.Column<int>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    LapRecord = table.Column<string>(maxLength: 10, nullable: true),
                    DriverID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.CircuitID);
                    table.ForeignKey(
                        name: "FK_Circuits_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "DriverID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_DriverID",
                table: "Circuits",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_TeamID",
                table: "Drivers",
                column: "TeamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
