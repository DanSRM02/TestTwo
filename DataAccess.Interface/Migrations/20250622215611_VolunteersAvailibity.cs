using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class VolunteersAvailibity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Volunteers");

            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Volunteers",
                newName: "SkillsAndExperience");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Volunteers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "DateBirth",
                table: "Volunteers",
                newName: "BirthDate");

            migrationBuilder.CreateTable(
                name: "VolunteerAvailabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerId = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerAvailabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerAvailabilities_Volunteers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Volunteers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerAvailabilities_VolunteerId",
                table: "VolunteerAvailabilities",
                column: "VolunteerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerAvailabilities");

            migrationBuilder.RenameColumn(
                name: "SkillsAndExperience",
                table: "Volunteers",
                newName: "Skills");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Volunteers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Volunteers",
                newName: "DateBirth");

            migrationBuilder.AddColumn<DateTime>(
                name: "Availability",
                table: "Volunteers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
