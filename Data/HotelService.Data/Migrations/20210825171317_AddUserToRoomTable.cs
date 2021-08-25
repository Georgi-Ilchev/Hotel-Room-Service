using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelService.Data.Migrations
{
    public partial class AddUserToRoomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_UserId1",
                table: "Rooms",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_UserId1",
                table: "Rooms",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_UserId1",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_UserId1",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rooms");
        }
    }
}
