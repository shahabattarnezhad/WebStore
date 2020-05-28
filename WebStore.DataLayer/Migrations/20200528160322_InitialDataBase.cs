using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStore.DataLayer.Migrations
{
    public partial class InitialDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 200, nullable: false),
                    UserEmail = table.Column<string>(maxLength: 200, nullable: false),
                    UserPassword = table.Column<string>(maxLength: 200, nullable: false),
                    UserActiveCode = table.Column<string>(nullable: true),
                    UserIsActive = table.Column<bool>(nullable: false),
                    UserAvatar = table.Column<string>(nullable: true),
                    UserRegisterDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_UserRole", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_Tbl_UserRole_Tbl_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Tbl_Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_UserRole_Tbl_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Tbl_User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserRole_RoleId",
                table: "Tbl_UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserRole_UserId",
                table: "Tbl_UserRole",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_UserRole");

            migrationBuilder.DropTable(
                name: "Tbl_Role");

            migrationBuilder.DropTable(
                name: "Tbl_User");
        }
    }
}
