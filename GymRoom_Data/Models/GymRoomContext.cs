using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GymRoom_Data.Models;

public partial class GymRoomContext : DbContext
{
    public GymRoomContext()
    {
    }

    public GymRoomContext(DbContextOptions<GymRoomContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CatCoach> CatCoaches { get; set; }

    public virtual DbSet<CatExercise> CatExercises { get; set; }

    public virtual DbSet<CatRoutine> CatRoutines { get; set; }

    public virtual DbSet<TblMember> TblMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Anita-San\\SQLEXPRESS;Database=GymRoom;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatCoach>(entity =>
        {
            entity.HasKey(e => e.IdCoach).HasName("PK__Cat_Coac__448A1C7C8AC12FC2");

            entity.ToTable("Cat_Coach");

            entity.Property(e => e.IdCoach).HasColumnName("idCoach");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CatExercise>(entity =>
        {
            entity.HasKey(e => e.IdExercises).HasName("PK__Cat_Exer__4C95B9188A39A09A");

            entity.ToTable("Cat_Exercises");

            entity.Property(e => e.IdExercises).HasColumnName("idExercises");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CatRoutine>(entity =>
        {
            entity.HasKey(e => e.IdRoutine).HasName("PK__Cat_Rout__99D02BFFABA31A74");

            entity.ToTable("Cat_Routine");

            entity.Property(e => e.IdRoutine).HasColumnName("idRoutine");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.IdExercises).HasColumnName("idExercises");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            entity.HasOne(d => d.IdExercisesNavigation).WithMany(p => p.CatRoutines)
                .HasForeignKey(d => d.IdExercises)
                .HasConstraintName("FK_Routine_Exercises");
        });

        modelBuilder.Entity<TblMember>(entity =>
        {
            entity.HasKey(e => e.IdMember).HasName("PK__Tbl_Memb__7399FC4EADB336B1");

            entity.ToTable("Tbl_Member");

            entity.Property(e => e.IdMember).HasColumnName("idMember");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IdCoach).HasColumnName("idCoach");
            entity.Property(e => e.IdRoutine).HasColumnName("idRoutine");
            entity.Property(e => e.NameMember)
                .HasMaxLength(100)
                .HasColumnName("nameMember");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("weight");

            entity.HasOne(d => d.IdCoachNavigation).WithMany(p => p.TblMembers)
                .HasForeignKey(d => d.IdCoach)
                .HasConstraintName("FK_Member_Coach");

            entity.HasOne(d => d.IdRoutineNavigation).WithMany(p => p.TblMembers)
                .HasForeignKey(d => d.IdRoutine)
                .HasConstraintName("FK_Member_Routine");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
