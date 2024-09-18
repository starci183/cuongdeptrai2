using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CuongDepTrai2.Models;

public partial class FlowerContext : DbContext
{
    public FlowerContext()
    {
    }

    public FlowerContext(DbContextOptions<FlowerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Flower> Flowers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=3.108.250.160;Database=flower;Uid=sa;Pwd=Cuong123_A1;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Flower>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__flowers__3213E83FA8609A3E");

            entity.ToTable("flowers");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
