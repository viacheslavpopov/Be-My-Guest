using Microsoft.EntityFrameworkCore.Migrations;

namespace BeMyGuest.Migrations
{
    public partial class CreateGuestCovidInfoClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuestCovidInfoId",
                table: "CovidDataSet",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuestCovidInfoId",
                table: "CovidDataSet");
        }
    }
}
