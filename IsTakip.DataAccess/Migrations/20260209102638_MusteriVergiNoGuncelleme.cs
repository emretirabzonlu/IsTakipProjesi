using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Business.Migrations
{
    /// <inheritdoc />
    public partial class MusteriVergiNoGuncelleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BitisTarihi",
                table: "Gorevler");

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Durum",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Durum",
                table: "Gorevler",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "BitisTarihi",
                table: "Gorevler",
                type: "datetime2",
                nullable: true);
        }
    }
}
