using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace time_of_your_life.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FontFamily = table.Column<string>(type: "TEXT", nullable: false),
                    TitleFontSize = table.Column<int>(type: "INTEGER", nullable: false),
                    ClockFontSize = table.Column<int>(type: "INTEGER", nullable: false),
                    BlinkColons = table.Column<bool>(type: "INTEGER", nullable: false),
                    FontColor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presets");
        }
    }
}
