using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApi.Migrations
{
    public partial class EditQsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 4,
                column: "Question",
                value: "Do you have any of the following symptoms? 1. Fever 2. Cough 3. Shortness of Breathe");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 5,
                column: "Question",
                value: "Do you have any other symptoms not listed? List all that apply");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 4,
                column: "Question",
                value: "Do you have any of the following symptoms?");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 5,
                column: "Question",
                value: "Do you have any other symptoms? List all that apply");
        }
    }
}
