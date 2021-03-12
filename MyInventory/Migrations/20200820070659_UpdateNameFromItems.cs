using Microsoft.EntityFrameworkCore.Migrations;

namespace MyInventory.Migrations
{
    public partial class UpdateNameFromItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
