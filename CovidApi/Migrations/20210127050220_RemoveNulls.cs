using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApi.Migrations
{
    public partial class RemoveNulls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 2,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 3,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 4,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 5,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 6,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 7,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 8,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { 1, false, "false", false, "false", false, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 2,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 3,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 4,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 5,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 6,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 7,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 8,
                columns: new[] { "AgeAnswer", "Cough", "Explanation", "Fever", "SexAnswer", "Sob", "YesNo" },
                values: new object[] { null, null, null, null, null, null, null });
        }
    }
}
