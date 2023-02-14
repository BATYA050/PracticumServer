using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectR_B.Context.Migrations
{
    public partial class _55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_children_user_userId",
                table: "children");

            migrationBuilder.DropPrimaryKey(
                name: "PK_children",
                table: "children");

            migrationBuilder.RenameTable(
                name: "children",
                newName: "Children");

            migrationBuilder.RenameIndex(
                name: "IX_children_userId",
                table: "Children",
                newName: "IX_Children_userId");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "Children",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IdChildren",
                table: "Children",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Children",
                table: "Children",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_user_userId",
                table: "Children",
                column: "userId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_user_userId",
                table: "Children");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Children",
                table: "Children");

            migrationBuilder.RenameTable(
                name: "Children",
                newName: "children");

            migrationBuilder.RenameIndex(
                name: "IX_Children_userId",
                table: "children",
                newName: "IX_children_userId");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "user",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "children",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IdChildren",
                table: "children",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_children",
                table: "children",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_children_user_userId",
                table: "children",
                column: "userId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
