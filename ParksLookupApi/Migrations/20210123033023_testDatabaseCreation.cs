using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookupApi.Migrations
{
    public partial class testDatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ValueToDelete",
                table: "Parks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValueToDelete",
                table: "Parks");
        }
    }
}
