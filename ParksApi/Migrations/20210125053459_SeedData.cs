using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Parks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateOrNational",
                table: "Parks",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 1, "Mount Rainier", "Washington", "National" },
                    { 2, "North Cascades", "Washington", "National" },
                    { 3, "Olympic", "Washington", "National" },
                    { 4, "Crater Lake", "Oregon", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "State",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "StateOrNational",
                table: "Parks");
        }
    }
}
