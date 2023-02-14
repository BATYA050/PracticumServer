using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectR_B.Context.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddLocations");

            migrationBuilder.DropTable(
                name: "PageType");

            migrationBuilder.DropTable(
                name: "InvitedAdvertisment");

            migrationBuilder.DropTable(
                name: "AdvertismentSize");

            migrationBuilder.DropTable(
                name: "FontSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user");

            migrationBuilder.RenameColumn(
                name: "UserLastName",
                table: "user",
                newName: "Min");

            migrationBuilder.RenameColumn(
                name: "UserFirstName",
                table: "user",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PhoneUser",
                table: "user",
                newName: "HMO");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "user",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "children",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_children_user_userId",
                        column: x => x.userId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_children_userId",
                table: "children",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "children");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "user");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Min",
                table: "User",
                newName: "UserLastName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "UserFirstName");

            migrationBuilder.RenameColumn(
                name: "HMO",
                table: "User",
                newName: "PhoneUser");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "AdvertismentSize",
                columns: table => new
                {
                    AdvertismentSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lenth = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertismentSize", x => x.AdvertismentSizeId);
                });

            migrationBuilder.CreateTable(
                name: "FontSize",
                columns: table => new
                {
                    FontSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxSize = table.Column<int>(type: "int", nullable: false),
                    MinSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FontSize", x => x.FontSizeId);
                });

            migrationBuilder.CreateTable(
                name: "PageType",
                columns: table => new
                {
                    PageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageType", x => x.PageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "InvitedAdvertisment",
                columns: table => new
                {
                    InvitedAdvertismentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertismentSizeId = table.Column<int>(type: "int", nullable: false),
                    FontSizeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PageTypeId = table.Column<int>(type: "int", nullable: false),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvitedAdvertisment", x => x.InvitedAdvertismentId);
                    table.ForeignKey(
                        name: "FK_InvitedAdvertisment_AdvertismentSize_AdvertismentSizeId",
                        column: x => x.AdvertismentSizeId,
                        principalTable: "AdvertismentSize",
                        principalColumn: "AdvertismentSizeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvitedAdvertisment_FontSize_FontSizeId",
                        column: x => x.FontSizeId,
                        principalTable: "FontSize",
                        principalColumn: "FontSizeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvitedAdvertisment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvitedAdvertismentId = table.Column<int>(type: "int", nullable: false),
                    PageNum = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddLocations_InvitedAdvertisment_InvitedAdvertismentId",
                        column: x => x.InvitedAdvertismentId,
                        principalTable: "InvitedAdvertisment",
                        principalColumn: "InvitedAdvertismentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddLocations_InvitedAdvertismentId",
                table: "AddLocations",
                column: "InvitedAdvertismentId");

            migrationBuilder.CreateIndex(
                name: "IX_InvitedAdvertisment_AdvertismentSizeId",
                table: "InvitedAdvertisment",
                column: "AdvertismentSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvitedAdvertisment_FontSizeId",
                table: "InvitedAdvertisment",
                column: "FontSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_InvitedAdvertisment_UserId",
                table: "InvitedAdvertisment",
                column: "UserId");
        }
    }
}
