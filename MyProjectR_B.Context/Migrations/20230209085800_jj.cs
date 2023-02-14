using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectR_B.Context.Migrations
{
    public partial class jj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_User_IdU",
                table: "Children");

            migrationBuilder.AlterColumn<int>(
                name: "IdU",
                table: "Children",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_User_IdU",
                table: "Children",
                column: "IdU",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_User_IdU",
                table: "Children");

            migrationBuilder.AlterColumn<int>(
                name: "IdU",
                table: "Children",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Children_User_IdU",
                table: "Children",
                column: "IdU",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
