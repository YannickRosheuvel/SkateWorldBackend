using CourseHandling.Models;
using DistributedSkateWorld.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistributedSkateWorld.DAL
{
    public partial class SkateWorldContext : DbContext
    {
        public SkateWorldContext()
        {
        }

        public SkateWorldContext(DbContextOptions<SkateWorldContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Trick> Trick { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCourses> UserCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=mssql.fhict.local;Initial Catalog=dbi429901_skateworld;Persist Security Info=True;User ID=dbi429901_skateworld;Password=StarWars1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);
            });


            modelBuilder.Entity<UserCourses>()
                .HasKey(x => new { x.UserID, x.CourseID });
            modelBuilder.Entity<UserCourses>()
                .HasOne(x => x.User)
                .WithMany(m => m.Courses)
                .HasForeignKey(x => x.UserID);
            modelBuilder.Entity<UserCourses>()
                .HasOne(x => x.Course)
                .WithMany(e => e.Users)
                .HasForeignKey(x => x.CourseID);


            modelBuilder.Entity<Trick>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.VideoPath)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Trick)
                    .HasForeignKey<Trick>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trick_Course");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Rank).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Xp)
                    .HasColumnName("XP")
                    .HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
