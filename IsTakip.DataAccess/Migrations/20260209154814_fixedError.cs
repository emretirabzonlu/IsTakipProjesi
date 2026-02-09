using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IsTakip.Business.Migrations
{
    /// <inheritdoc />
    public partial class fixedError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Departmanlar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departmanlar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projeler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 1);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    GorevId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    ToplamSaat = table.Column<double>(type: "float", nullable: false)
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
                    GorevId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    Uzanti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YukleyenPersonelId = table.Column<int>(type: "int", nullable: false)
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
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    SiraNo = table.Column<int>(type: "int", nullable: false)
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
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    Simge = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    GorevId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Departmanlar",
                columns: new[] { "Id", "Ad", "OlusturmaTarihi", "SilindiMi" },
                values: new object[,]
                {
                    { 1, "Yazılım Ekibi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, "Yönetim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "GorevDurumlari",
                columns: new[] { "Id", "Ad", "OlusturmaTarihi", "SilindiMi", "SiraNo" },
                values: new object[,]
                {
                    { 1, "Bekliyor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 },
                    { 2, "Analiz Aşamasında", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 3, "Geliştiriliyor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 },
                    { 4, "Test Aşamasında", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 4 },
                    { 5, "Tamamlandı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5 },
                    { 6, "İptal Edildi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 6 }
                });

            migrationBuilder.InsertData(
                table: "GorevOncelikleri",
                columns: new[] { "Id", "Ad", "Derece", "OlusturmaTarihi", "Renk", "SilindiMi" },
                values: new object[,]
                {
                    { 1, "Düşük", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gri", false },
                    { 2, "Normal", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mavi", false },
                    { 3, "Yüksek", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turuncu", false },
                    { 4, "Kritik (Acil)", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırmızı", false }
                });

            migrationBuilder.InsertData(
                table: "GorevTipleri",
                columns: new[] { "Id", "Ad", "OlusturmaTarihi", "SilindiMi", "Simge" },
                values: new object[,]
                {
                    { 1, "Geliştirme (Feature)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "🔨" },
                    { 2, "Hata Düzeltme (Bug)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "🐛" },
                    { 3, "Araştırma (R&D)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "🔍" },
                    { 4, "Destek", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "🚑" }
                });

            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "Id", "Ad", "Adres", "Email", "OlusturmaTarihi", "SilindiMi", "Telefon", "VergiNo", "Yetkili" },
                values: new object[] { 1, "Şirket İçi", "Merkez", "info@sirket.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "000", "111", "Ben" });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "Id", "Ad", "Kod", "OlusturmaTarihi", "SilindiMi" },
                values: new object[,]
                {
                    { 1, "Yönetici", "ADMIN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, "Takım Lideri", "LEAD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, "Personel", "USER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "Projeler",
                columns: new[] { "Id", "Aciklama", "Ad", "BaslangicTarihi", "BitisTarihi", "Durum", "MusteriId", "OlusturmaTarihi", "SilindiMi" },
                values: new object[] { 1, "Projesiz görevler buraya", "Genel İşler", new DateTime(2026, 2, 9, 18, 28, 37, 929, DateTimeKind.Local).AddTicks(3323), null, "Aktif", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

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
    }
}
