using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApi.Migrations
{
    public partial class CreateNullAnswersAddSecondQ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "Evidences",
                newName: "SexAnswer");

            migrationBuilder.AlterColumn<bool>(
                name: "MultipleAnswer",
                table: "Evidences",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<int>(
                name: "AgeAnswer",
                table: "Evidences",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                columns: new[] { "Explanation", "MultipleAnswer" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "Evidences",
                columns: new[] { "EvidenceId", "AgeAnswer", "DiagnosisId", "Explanation", "MultipleAnswer", "Question", "SexAnswer" },
                values: new object[] { 2, 20, 1, null, null, "What is your age?", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AgeAnswer",
                table: "Evidences");

            migrationBuilder.RenameColumn(
                name: "SexAnswer",
                table: "Evidences",
                newName: "Answer");

            migrationBuilder.AlterColumn<bool>(
                name: "MultipleAnswer",
                table: "Evidences",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Evidences",
                keyColumn: "EvidenceId",
                keyValue: 1,
                columns: new[] { "Explanation", "MultipleAnswer" },
                values: new object[] { "none", false });
        }
    }
}
