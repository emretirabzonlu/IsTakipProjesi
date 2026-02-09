using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IsTakip.Business.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departmanlar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departmanlar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GorevDurumlari",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GorevDurumlari",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GorevDurumlari",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GorevDurumlari",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GorevDurumlari",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GorevDurumlari",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GorevOncelikleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GorevOncelikleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GorevOncelikleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GorevOncelikleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GorevTipleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GorevTipleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GorevTipleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GorevTipleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projeler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roller",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
