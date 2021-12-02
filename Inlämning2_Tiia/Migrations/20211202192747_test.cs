using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning2_Tiia.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Father",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Mother",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "FatherId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MotherId",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "Father",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mother",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
