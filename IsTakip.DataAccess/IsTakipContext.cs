using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using IsTakip.Entities;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.Business
{
    public class IsTakipContext : DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Gorev> Gorevler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Proje> Projeler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Buradaki Server adresini kendi bilgisayarına göre ayarla
            // SQL Express ise: Server=.\SQLEXPRESS veya Server=(localdb)\mssqllocaldb
            // Tam SQL ise: Server=. veya Server=localhost
            optionsBuilder.UseSqlServer("Server=.;Database=IsTakipDb;Integrated Security=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --------------- PERSONEL TABLOSU AYARLARI ---------------
            // 1. Primary Key'i açıkça belirtiyoruz
            modelBuilder.Entity<Personel>().HasKey(p => p.Id);

            // 2. Alan özelliklerini (Constraints) belirtiyoruz
            modelBuilder.Entity<Personel>().Property(p => p.Ad).HasMaxLength(50).IsRequired(); // NVARCHAR(50), NOT NULL
            modelBuilder.Entity<Personel>().Property(p => p.Soyad).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Personel>().Property(p => p.Email).HasMaxLength(100);

            // 3. İlişkileri açıkça belirtiyoruz (Best Practice)
            // "Bir personelin bir departmanı vardır, bir departmanın çok personeli vardır."
            modelBuilder.Entity<Personel>()
                .HasOne(p => p.Departman)
                .WithMany(d => d.Personeller)
                .HasForeignKey(p => p.DepartmanId)
                .OnDelete(DeleteBehavior.Restrict); // ÖNEMLİ: Departman silinirse personeller silinmesin! (Güvenlik)


            // --------------- GÖREV TABLOSU AYARLARI ---------------
            modelBuilder.Entity<Gorev>().HasKey(g => g.Id);

            modelBuilder.Entity<Gorev>().Property(g => g.Baslik).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Gorev>().Property(g => g.Aciklama).HasColumnType("ntext"); // Uzun metinler için

            // İlişki: Personel silinirse görevler ne olsun?
            modelBuilder.Entity<Gorev>()
                .HasOne(g => g.Personel)
                .WithMany(p => p.Gorevler)
                .HasForeignKey(g => g.PersonelId)
                .OnDelete(DeleteBehavior.Cascade); // Personel silinirse görevleri de silinsin (veya Restrict yapabilirsin)


            // --------------- DEPARTMAN TABLOSU AYARLARI ---------------
            modelBuilder.Entity<Departman>().HasKey(d => d.Id);
            modelBuilder.Entity<Departman>().Property(d => d.Ad).HasMaxLength(100).IsRequired();

            // --------------- MÜŞTERİ TABLOSU ---------------
            modelBuilder.Entity<Musteri>().HasKey(m => m.Id);
            modelBuilder.Entity<Musteri>().Property(m => m.Ad).HasMaxLength(100).IsRequired();

            // --------------- PROJE TABLOSU ---------------
            modelBuilder.Entity<Proje>().HasKey(p => p.Id);
            modelBuilder.Entity<Proje>().Property(p => p.ProjeAdi).HasMaxLength(100).IsRequired();

            // İLİŞKİ: Bir Müşterinin Çok Projesi Olur
            modelBuilder.Entity<Proje>()
                .HasOne(p => p.Musteri)
                .WithMany(m => m.Projeler)
                .HasForeignKey(p => p.MusteriId)
                .OnDelete(DeleteBehavior.Restrict); // Müşteri silinirse projeleri silinmesin, hata versin.


            base.OnModelCreating(modelBuilder);
        }
    }
}
