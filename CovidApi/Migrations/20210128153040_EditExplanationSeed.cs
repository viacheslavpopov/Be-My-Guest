using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApi.Migrations
{
    public partial class EditExplanationSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                column: "Explanation",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 2,
                column: "Explanation",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 3,
                column: "Explanation",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 4,
                column: "Explanation",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 5,
                column: "Explanation",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 6,
                column: "Explanation",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 7,
                column: "Explanation",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 8,
                column: "Explanation",
                value: " ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                column: "Explanation",
                value: "false");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 2,
                column: "Explanation",
                value: "false");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 3,
                column: "Explanation",
                value: "false");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 4,
                column: "Explanation",
                value: "false");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 5,
                column: "Explanation",
                value: "false");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 6,
                column: "Explanation",
                value: "false");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 7,
                column: "Explanation",
                value: "false");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 8,
                column: "Explanation",
                value: "false");
        }
    }
}
