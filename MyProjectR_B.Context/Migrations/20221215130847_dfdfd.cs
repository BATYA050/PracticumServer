using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjectR_B.Context.Migrations
{
    public partial class dfdfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    MinSize = table.Column<int>(type: "int", nullable: false),
                    MaxSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FontSize", x => x.FontSizeId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "InvitedAdvertisment",
                columns: table => new
                {
                    InvitedAdvertismentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FontSizeId = table.Column<int>(type: "int", nullable: false),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertismentSizeId = table.Column<int>(type: "int", nullable: false)
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
                    InvitedAdvertismentId = table.Column<int>(type: "int", nullable: true),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    PageNum = table.Column<int>(type: "int", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddLocations");

            migrationBuilder.DropTable(
                name: "InvitedAdvertisment");

            migrationBuilder.DropTable(
                name: "AdvertismentSize");

            migrationBuilder.DropTable(
                name: "FontSize");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
