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
        public DbSet<GorevDurum> GorevDurumlar { get; set; }
        public DbSet<GorevYorum> GorevYorumlar { get; set; }
        public DbSet<Rol> Roller { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=IsTakipDb;Integrated Security=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --------------- PERSONEL TABLOSU AYARLARI ---------------
            modelBuilder.Entity<Personel>().HasKey(p => p.Id);
            modelBuilder.Entity<Personel>().Property(p => p.Ad).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Personel>().Property(p => p.Soyad).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Personel>().Property(p => p.Email).HasMaxLength(100);
            modelBuilder.Entity<Personel>().Property(p => p.Sifre).HasMaxLength(100);

            modelBuilder.Entity<Personel>()
                .HasOne(p => p.Departman)
                .WithMany(d => d.Personeller)
                .HasForeignKey(p => p.DepartmanId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Personel>()
                .HasOne(p => p.Rol)
                .WithMany(r => r.Personeller)
                .HasForeignKey(p => p.RolId)
                .OnDelete(DeleteBehavior.Restrict);

            // --------------- GÖREV TABLOSU AYARLARI ---------------
            modelBuilder.Entity<Gorev>().HasKey(g => g.Id);
            modelBuilder.Entity<Gorev>().Property(g => g.Baslik).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Gorev>().Property(g => g.Aciklama).HasColumnType("ntext");

            modelBuilder.Entity<Gorev>()
                .HasOne(g => g.Personel)
                .WithMany(p => p.Gorevler)
                .HasForeignKey(g => g.PersonelId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Gorev>()
                .HasOne(g => g.GorevDurum)
                .WithMany(gd => gd.Gorevler)
                .HasForeignKey(g => g.GorevDurumId)
                .OnDelete(DeleteBehavior.Restrict);

            // --------------- DEPARTMAN TABLOSU AYARLARI ---------------
            modelBuilder.Entity<Departman>().HasKey(d => d.Id);
            modelBuilder.Entity<Departman>().Property(d => d.Ad).HasMaxLength(100).IsRequired();

            // --------------- MÜŞTERİ TABLOSU ---------------
            modelBuilder.Entity<Musteri>().HasKey(m => m.Id);
            modelBuilder.Entity<Musteri>().Property(m => m.Ad).HasMaxLength(100).IsRequired();

            // --------------- PROJE TABLOSU ---------------
            modelBuilder.Entity<Proje>().HasKey(p => p.Id);
            modelBuilder.Entity<Proje>().Property(p => p.ProjeAdi).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Proje>()
                .HasOne(p => p.Musteri)
                .WithMany(m => m.Projeler)
                .HasForeignKey(p => p.MusteriId)
                .OnDelete(DeleteBehavior.Restrict);

            // --------------- GÖREV DURUM ---------------
            modelBuilder.Entity<GorevDurum>().HasKey(gd => gd.Id);
            modelBuilder.Entity<GorevDurum>().Property(gd => gd.Ad).HasMaxLength(50).IsRequired();

            // --------------- GÖREV YORUM ---------------
            modelBuilder.Entity<GorevYorum>().HasKey(gy => gy.Id);
            modelBuilder.Entity<GorevYorum>().Property(gy => gy.Icerik).HasMaxLength(500).IsRequired();

            modelBuilder.Entity<GorevYorum>()
                .HasOne(gy => gy.Gorev)
                .WithMany(g => g.Yorumlar)
                .HasForeignKey(gy => gy.GorevId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GorevYorum>()
                .HasOne(gy => gy.Personel)
                .WithMany()
                .HasForeignKey(gy => gy.PersonelId)
                .OnDelete(DeleteBehavior.Restrict);

            // --------------- ROL ---------------
            modelBuilder.Entity<Rol>().HasKey(r => r.Id);
            modelBuilder.Entity<Rol>().Property(r => r.Ad).HasMaxLength(50).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
