using Microsoft.EntityFrameworkCore.Migrations;

namespace BeMyGuest.Migrations
{
    public partial class EditCovidProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighRisk",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "Prescreening",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "RecentTravel",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "Vaccine",
                table: "CovidDataSet");

            migrationBuilder.RenameColumn(
                name: "Symptoms",
                table: "CovidDataSet",
                newName: "SexAnswer");

            migrationBuilder.RenameColumn(
                name: "ExposureLevel",
                table: "CovidDataSet",
                newName: "Question");

            migrationBuilder.AddColumn<int>(
                name: "AgeAnswer",
                table: "CovidDataSet",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Cough",
                table: "CovidDataSet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "CovidDataSet",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Fever",
                table: "CovidDataSet",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Sob",
                table: "CovidDataSet",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "YesNo",
                table: "CovidDataSet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeAnswer",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "Cough",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "Fever",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "Sob",
                table: "CovidDataSet");

            migrationBuilder.DropColumn(
                name: "YesNo",
                table: "CovidDataSet");

            migrationBuilder.RenameColumn(
                name: "SexAnswer",
                table: "CovidDataSet",
                newName: "Symptoms");

            migrationBuilder.RenameColumn(
                name: "Question",
                table: "CovidDataSet",
                newName: "ExposureLevel");

            migrationBuilder.AddColumn<bool>(
                name: "HighRisk",
                table: "CovidDataSet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Prescreening",
                table: "CovidDataSet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RecentTravel",
                table: "CovidDataSet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vaccine",
                table: "CovidDataSet",
                nullable: false,
                defaultValue: false);
        }
    }
}
