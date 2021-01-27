using Microsoft.EntityFrameworkCore.Migrations;

namespace BeMyGuest.Migrations
{
    public partial class AddEventTitleProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventTitle",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventTitle",
                table: "Events");
        }
    }
}
