using Microsoft.EntityFrameworkCore.Migrations;

namespace BeMyGuest.Migrations
{
    public partial class RenameGathering : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gatherings_Events_EventId",
                table: "Gatherings");

            migrationBuilder.DropForeignKey(
                name: "FK_Gatherings_Guests_GuestId",
                table: "Gatherings");

            migrationBuilder.DropForeignKey(
                name: "FK_Gatherings_Hosts_HostId",
                table: "Gatherings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gatherings",
                table: "Gatherings");

            migrationBuilder.RenameTable(
                name: "Gatherings",
                newName: "Gathering");

            migrationBuilder.RenameIndex(
                name: "IX_Gatherings_HostId",
                table: "Gathering",
                newName: "IX_Gathering_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_Gatherings_GuestId",
                table: "Gathering",
                newName: "IX_Gathering_GuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Gatherings_EventId",
                table: "Gathering",
                newName: "IX_Gathering_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gathering",
                table: "Gathering",
                column: "GatheringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gathering_Events_EventId",
                table: "Gathering",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gathering_Guests_GuestId",
                table: "Gathering",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "GuestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gathering_Hosts_HostId",
                table: "Gathering",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "HostId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gathering_Events_EventId",
                table: "Gathering");

            migrationBuilder.DropForeignKey(
                name: "FK_Gathering_Guests_GuestId",
                table: "Gathering");

            migrationBuilder.DropForeignKey(
                name: "FK_Gathering_Hosts_HostId",
                table: "Gathering");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gathering",
                table: "Gathering");

            migrationBuilder.RenameTable(
                name: "Gathering",
                newName: "Gatherings");

            migrationBuilder.RenameIndex(
                name: "IX_Gathering_HostId",
                table: "Gatherings",
                newName: "IX_Gatherings_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_Gathering_GuestId",
                table: "Gatherings",
                newName: "IX_Gatherings_GuestId");

            migrationBuilder.RenameIndex(
                name: "IX_Gathering_EventId",
                table: "Gatherings",
                newName: "IX_Gatherings_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gatherings",
                table: "Gatherings",
                column: "GatheringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gatherings_Events_EventId",
                table: "Gatherings",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gatherings_Guests_GuestId",
                table: "Gatherings",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "GuestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gatherings_Hosts_HostId",
                table: "Gatherings",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "HostId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
