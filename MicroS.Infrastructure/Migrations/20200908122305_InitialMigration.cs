using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroS.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    IdReg = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.IdReg);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rut = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    ApellidoP = table.Column<string>(nullable: true),
                    Actiive = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Comuna",
                columns: table => new
                {
                    IdReg = table.Column<int>(nullable: false),
                    IdCom = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comuna", x => x.IdReg);
                    table.ForeignKey(
                        name: "FK_Comuna_Region_IdReg",
                        column: x => x.IdReg,
                        principalTable: "Region",
                        principalColumn: "IdReg",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User2Comuna",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false),
                    IdCom = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User2Comuna", x => new { x.IdUser, x.IdCom });
                    table.ForeignKey(
                        name: "FK_User2Comuna_Comuna_IdCom",
                        column: x => x.IdCom,
                        principalTable: "Comuna",
                        principalColumn: "IdReg",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User2Comuna_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User2Comuna_IdCom",
                table: "User2Comuna",
                column: "IdCom");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User2Comuna");

            migrationBuilder.DropTable(
                name: "Comuna");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
