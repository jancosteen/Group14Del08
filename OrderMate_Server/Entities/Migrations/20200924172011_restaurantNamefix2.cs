using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class restaurantNamefix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.RenameColumn(
                name: "Resaturant_Address_Line_2",
                table: "Restaurant",
                newName: "Restaurant_Address_Line_2");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Restaurant_Address_Line_2",
                table: "Restaurant",
                newName: "Resaturant_Address_Line_2");
        }
    }
}
