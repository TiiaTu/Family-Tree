using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning2_Tiia.Migrations
{
    public partial class newTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MotherId",
                table: "Persons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FatherId",
                table: "Persons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_FatherId",
                table: "Persons",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MotherId",
                table: "Persons",
                column: "MotherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_FatherId",
                table: "Persons",
                column: "FatherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_MotherId",
                table: "Persons",
                column: "MotherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_FatherId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_MotherId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_FatherId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MotherId",
                table: "Persons");

            migrationBuilder.AlterColumn<int>(
                name: "MotherId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FatherId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
