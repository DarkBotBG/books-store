﻿using System;
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

        public virtual DbSet<Kniga> Knigi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning: 'To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.'
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PTIRMGL\\SQLEXPRESS;Database=Library3;Integrated Security=True;");
#pragma warning restore CS1030 // #warning: 'To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.'
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

                entity.Property(e => e.Author)
                    .HasColumnName("Author")
                    .HasMaxLength(10);

                entity.Property(e => e.Publisher)
                    .HasColumnName("Publisher")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Price).HasColumnName("Price");
            });
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
