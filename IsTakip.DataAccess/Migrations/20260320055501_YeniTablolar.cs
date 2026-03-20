using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Business.Migrations
{
    /// <inheritdoc />
    public partial class YeniTablolar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Gorevler");

            migrationBuilder.AlterColumn<string>(
                name: "Sifre",
                table: "Personeller",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Personeller",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GorevDurumId",
                table: "Gorevler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GorevDurumlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevDurumlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GorevYorumlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icerik = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GorevId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevYorumlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GorevYorumlar_Gorevler_GorevId",
                        column: x => x.GorevId,
                        principalTable: "Gorevler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GorevYorumlar_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_RolId",
                table: "Personeller",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_GorevDurumId",
                table: "Gorevler",
                column: "GorevDurumId");

            migrationBuilder.CreateIndex(
                name: "IX_GorevYorumlar_GorevId",
                table: "GorevYorumlar",
                column: "GorevId");

            migrationBuilder.CreateIndex(
                name: "IX_GorevYorumlar_PersonelId",
                table: "GorevYorumlar",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_GorevDurumlar_GorevDurumId",
                table: "Gorevler",
                column: "GorevDurumId",
                principalTable: "GorevDurumlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personeller_Roller_RolId",
                table: "Personeller",
                column: "RolId",
                principalTable: "Roller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_GorevDurumlar_GorevDurumId",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Personeller_Roller_RolId",
                table: "Personeller");

            migrationBuilder.DropTable(
                name: "GorevDurumlar");

            migrationBuilder.DropTable(
                name: "GorevYorumlar");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropIndex(
                name: "IX_Personeller_RolId",
                table: "Personeller");

            migrationBuilder.DropIndex(
                name: "IX_Gorevler_GorevDurumId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Personeller");

            migrationBuilder.DropColumn(
                name: "GorevDurumId",
                table: "Gorevler");

            migrationBuilder.AlterColumn<string>(
                name: "Sifre",
                table: "Personeller",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Durum",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
