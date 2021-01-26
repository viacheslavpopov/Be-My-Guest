using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApi.Migrations
{
    public partial class SeedDbQuestionsUpdateProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MultipleAnswer",
                table: "Evidences",
                newName: "YesNo");

            migrationBuilder.AddColumn<bool>(
                name: "Cough",
                table: "Evidences",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Fever",
                table: "Evidences",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sob",
                table: "Evidences",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                column: "SexAnswer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 2,
                column: "AgeAnswer",
                value: null);

            migrationBuilder.InsertData(
                table: "Evidences",
                columns: new[] { "EvidenceId", "AgeAnswer", "Cough", "DiagnosisId", "Explanation", "Fever", "Question", "SexAnswer", "Sob", "YesNo" },
                values: new object[,]
                {
                    { 3, null, null, 1, null, null, "Do you have an underlying conditions that put you at a high risk? List all that apply.", null, null, null },
                    { 4, null, null, 1, null, null, "Do you have any of the following symptoms?", null, null, null },
                    { 5, null, null, 1, null, null, "Do you have any other symptoms? List all that apply", null, null, null },
                    { 6, null, null, 1, null, null, "Have you recently lost the ability to smell or taste?", null, null, null },
                    { 7, null, null, 1, null, null, "Please explain your current exposure level.", null, null, null },
                    { 8, null, null, 1, null, null, "Have you recently traveled?", null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Cough",
                table: "Evidences");

            migrationBuilder.DropColumn(
                name: "Fever",
                table: "Evidences");

            migrationBuilder.DropColumn(
                name: "Sob",
                table: "Evidences");

            migrationBuilder.RenameColumn(
                name: "YesNo",
                table: "Evidences",
                newName: "MultipleAnswer");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                column: "SexAnswer",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 2,
                column: "AgeAnswer",
                value: 20);
        }
    }
}
