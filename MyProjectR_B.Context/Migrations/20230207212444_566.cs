using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectR_B.Context.Migrations
{
    public partial class _566 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_user_userId",
                table: "Children");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Children");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Children",
                newName: "IdU");

            migrationBuilder.RenameIndex(
                name: "IX_Children_userId",
                table: "Children",
                newName: "IX_Children_IdU");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_User_IdU",
                table: "Children",
                column: "IdU",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_User_IdU",
                table: "Children");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user");

            migrationBuilder.RenameColumn(
                name: "IdU",
                table: "Children",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Children_IdU",
                table: "Children",
                newName: "IX_Children_userId");

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "Children",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_user_userId",
                table: "Children",
                column: "userId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
