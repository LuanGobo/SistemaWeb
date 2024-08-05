using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWeb.Migrations
{
    public partial class OtherEntitiesCorrection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Seller");
        }
    }
}
