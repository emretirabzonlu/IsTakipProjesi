using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Business.Migrations
{
    /// <inheritdoc />
    public partial class EnterpriseKurulum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_Personeller_PersonelId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Gorevler");

            migrationBuilder.RenameColumn(
                name: "ProjeAdi",
                table: "Projeler",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "Musteriler",
                newName: "Yetkili");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "Gorevler",
                newName: "ProjeId");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevler_PersonelId",
                table: "Gorevler",
                newName: "IX_Gorevler_ProjeId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Personeller",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Personeller",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "ntext");

            migrationBuilder.AddColumn<int>(
                name: "AtananPersonelId",
                table: "Gorevler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DurumId",
                table: "Gorevler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OncelikId",
                table: "Gorevler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TahminiBitis",
                table: "Gorevler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipId",
                table: "Gorevler",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Departmanlar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "CalismaSureleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamSaat = table.Column<double>(type: "float", nullable: false),
                    GorevId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalismaSureleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalismaSureleri_Gorevler_GorevId",
                        column: x => x.GorevId,
                        principalTable: "Gorevler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalismaSureleri_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dosyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uzanti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GorevId = table.Column<int>(type: "int", nullable: false),
                    YukleyenPersonelId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dosyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dosyalar_Gorevler_GorevId",
                        column: x => x.GorevId,
                        principalTable: "Gorevler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GorevDurumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiraNo = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevDurumlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GorevOncelikleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Derece = table.Column<int>(type: "int", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevOncelikleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GorevTipleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Simge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevTipleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GorevYorumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GorevId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevYorumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GorevYorumlari_Gorevler_GorevId",
                        column: x => x.GorevId,
                        principalTable: "Gorevler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GorevYorumlari_Personeller_PersonelId",
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
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "IX_Gorevler_AtananPersonelId",
                table: "Gorevler",
                column: "AtananPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_DurumId",
                table: "Gorevler",
                column: "DurumId");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_OncelikId",
                table: "Gorevler",
                column: "OncelikId");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_TipId",
                table: "Gorevler",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_CalismaSureleri_GorevId",
                table: "CalismaSureleri",
                column: "GorevId");

            migrationBuilder.CreateIndex(
                name: "IX_CalismaSureleri_PersonelId",
                table: "CalismaSureleri",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Dosyalar_GorevId",
                table: "Dosyalar",
                column: "GorevId");

            migrationBuilder.CreateIndex(
                name: "IX_GorevYorumlari_GorevId",
                table: "GorevYorumlari",
                column: "GorevId");

            migrationBuilder.CreateIndex(
                name: "IX_GorevYorumlari_PersonelId",
                table: "GorevYorumlari",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_GorevDurumlari_DurumId",
                table: "Gorevler",
                column: "DurumId",
                principalTable: "GorevDurumlari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_GorevOncelikleri_OncelikId",
                table: "Gorevler",
                column: "OncelikId",
                principalTable: "GorevOncelikleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_GorevTipleri_TipId",
                table: "Gorevler",
                column: "TipId",
                principalTable: "GorevTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_Personeller_AtananPersonelId",
                table: "Gorevler",
                column: "AtananPersonelId",
                principalTable: "Personeller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_Projeler_ProjeId",
                table: "Gorevler",
                column: "ProjeId",
                principalTable: "Projeler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Gorevler_GorevDurumlari_DurumId",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_GorevOncelikleri_OncelikId",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_GorevTipleri_TipId",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_Personeller_AtananPersonelId",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_Projeler_ProjeId",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Personeller_Roller_RolId",
                table: "Personeller");

            migrationBuilder.DropTable(
                name: "CalismaSureleri");

            migrationBuilder.DropTable(
                name: "Dosyalar");

            migrationBuilder.DropTable(
                name: "GorevDurumlari");

            migrationBuilder.DropTable(
                name: "GorevOncelikleri");

            migrationBuilder.DropTable(
                name: "GorevTipleri");

            migrationBuilder.DropTable(
                name: "GorevYorumlari");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropIndex(
                name: "IX_Personeller_RolId",
                table: "Personeller");

            migrationBuilder.DropIndex(
                name: "IX_Gorevler_AtananPersonelId",
                table: "Gorevler");

            migrationBuilder.DropIndex(
                name: "IX_Gorevler_DurumId",
                table: "Gorevler");

            migrationBuilder.DropIndex(
                name: "IX_Gorevler_OncelikId",
                table: "Gorevler");

            migrationBuilder.DropIndex(
                name: "IX_Gorevler_TipId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Personeller");

            migrationBuilder.DropColumn(
                name: "AtananPersonelId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "DurumId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "OncelikId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "TahminiBitis",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "TipId",
                table: "Gorevler");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Projeler",
                newName: "ProjeAdi");

            migrationBuilder.RenameColumn(
                name: "Yetkili",
                table: "Musteriler",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "ProjeId",
                table: "Gorevler",
                newName: "PersonelId");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevler_ProjeId",
                table: "Gorevler",
                newName: "IX_Gorevler_PersonelId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Personeller",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Musteriler",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Gorevler",
                type: "ntext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Durum",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Departmanlar",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_Personeller_PersonelId",
                table: "Gorevler",
                column: "PersonelId",
                principalTable: "Personeller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
