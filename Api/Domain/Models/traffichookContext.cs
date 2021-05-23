using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Domain.Models
{
    public partial class traffichookContext : DbContext
    {
        public traffichookContext()
        {
        }

        public traffichookContext(DbContextOptions<traffichookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sensor> Sensors { get; set; }
        public virtual DbSet<VehicleDatum> VehicleData { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=traffichook;User id=traffichook;Password=d3YOdHPKLRZvYNMI;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Sensor>(entity =>
            {
                entity.HasKey(e => e.KeyExt);

                entity.ToTable("Sensor");

                entity.Property(e => e.KeyExt)
                    .ValueGeneratedNever()
                    .HasColumnName("keyExt");
            });

            modelBuilder.Entity<VehicleDatum>(entity =>
            {
                entity.HasIndex(e => e.Processed, "IX_VehicleData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Processed).HasColumnName("processed");

                entity.Property(e => e.SensorId).HasColumnName("sensorId");

                entity.Property(e => e.Speed)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("speed");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.HasOne(d => d.Sensor)
                    .WithMany(p => p.VehicleData)
                    .HasForeignKey(d => d.SensorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleData_VehicleType");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("VehicleType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
