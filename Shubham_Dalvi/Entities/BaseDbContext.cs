using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Shubham_Dalvi.Entities;

public partial class BaseDbContext : DbContext
{
    public BaseDbContext()
    {
    }

    public BaseDbContext(DbContextOptions<BaseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PersonalInfo> PersonalInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SHUBHAMJADHAV\\SQLEXPRESS;Database=PersonalData;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonalInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personal__3214EC07AE9663AB");

            entity.ToTable("PersonalInfo");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Message).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
