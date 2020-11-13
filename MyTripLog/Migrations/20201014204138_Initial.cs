using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTripLog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    AccName = table.Column<string>(nullable: true),
                    AccPhone = table.Column<string>(nullable: true),
                    AccEmail = table.Column<string>(nullable: true),
                    Activity1 = table.Column<string>(nullable: true),
                    Activity2 = table.Column<string>(nullable: true),
                    Activity3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
