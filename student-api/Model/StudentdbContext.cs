using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace student_api.Model;

public partial class StudentdbContext : DbContext
{
    public StudentdbContext()
    {
    }

    public StudentdbContext(DbContextOptions<StudentdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mbastudentdetail> Mbastudentdetails { get; set; }

    public virtual DbSet<Studentdetail> Studentdetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=13.57.241.145;Database=studentdb;Username=postgres;Password=example");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mbastudentdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mbastudentdetails");

            entity.Property(e => e.Mbastdgrade)
                .HasMaxLength(255)
                .HasColumnName("mbastdgrade");
            entity.Property(e => e.Mbastdmark).HasColumnName("mbastdmark");
            entity.Property(e => e.Mbastdname)
                .HasMaxLength(255)
                .HasColumnName("mbastdname");
        });

        modelBuilder.Entity<Studentdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("studentdetails");

            entity.Property(e => e.Stdgrade)
                .HasMaxLength(255)
                .HasColumnName("stdgrade");
            entity.Property(e => e.Stdmark).HasColumnName("stdmark");
            entity.Property(e => e.Stdname)
                .HasMaxLength(255)
                .HasColumnName("stdname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
