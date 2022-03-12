using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _5_3_2022.Models
{
    public partial class booksContext : DbContext
    {
        public booksContext()
        {
        }

        public booksContext(DbContextOptions<booksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kniga> Kniga { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PTIRMGL\\SQLEXPRESS;Database=books;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Kniga>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Автор)
                    .HasColumnName("автор")
                    .HasMaxLength(10);

                entity.Property(e => e.Издател)
                    .HasColumnName("издател")
                    .HasMaxLength(10);

                entity.Property(e => e.Име)
                    .HasColumnName("име")
                    .HasMaxLength(10);

                entity.Property(e => e.Цена).HasColumnName("цена");
            });
        }
    }
}
