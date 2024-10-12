using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project_Sem7.Models;

public partial class CUsersDellDocumentsGMartMdfContext : DbContext
{
    public CUsersDellDocumentsGMartMdfContext()
    {
    }

    public CUsersDellDocumentsGMartMdfContext(DbContextOptions<CUsersDellDocumentsGMartMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    //public virtual DbSet<Customer1> Customers1 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Documents\\G_mart.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07A16EBD88");

            entity.ToTable("Customer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Mobile_number");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        //modelBuilder.Entity<Customer1>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07C29439AC");

        //    entity.ToTable("Customers");

        //    entity.Property(e => e.Id).ValueGeneratedNever();
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(20)
        //        .IsFixedLength();
        //    entity.Property(e => e.Password)
        //        .HasMaxLength(8)
        //        .IsFixedLength();
        //    entity.Property(e => e.Phone)
        //        .HasMaxLength(10)
        //        .IsFixedLength();
        //    entity.Property(e => e.Username)
        //        .HasMaxLength(15)
        //        .IsFixedLength();
        //});

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
