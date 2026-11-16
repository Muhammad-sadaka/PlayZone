using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace PlayZone_DataAccessEF.Models;

public partial class PlayZoneContext : DbContext
{
    public PlayZoneContext()
    {
    }

    public PlayZoneContext(DbContextOptions<PlayZoneContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<ReservationProduct> ReservationProducts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Spot> Spots { get; set; }

    public virtual DbSet<SpotType> SpotTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(AppContext.BaseDirectory, "appsettings.json"), optional: false, reloadOnChange: true)
                .Build().GetConnectionString("DefaultConnection"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6ED314AC471");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Image).IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("PK__Reservat__B7EE5F044B7EAC8D");

            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.SpotTypeId).HasColumnName("SpotTypeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Shift).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reservations_Shifts");

            entity.HasOne(d => d.SpotType).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.SpotTypeId)
                .HasConstraintName("FK__Reservati__SpotT__60A75C0F");
        });

        modelBuilder.Entity<ReservationProduct>(entity =>
        {
            entity.HasKey(e => e.OrderProductId).HasName("PK__Reservat__29B019E27BF1C2CA");

            entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Product).WithMany(p => p.ReservationProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Reservati__Produ__68487DD7");

            entity.HasOne(d => d.Reservation).WithMany(p => p.ReservationProducts)
                .HasForeignKey(d => d.ReservationId)
                .HasConstraintName("FK__Reservati__Reser__6754599E");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3A69E37AEC");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.ShiftId).HasName("PK__Shifts__C0A838E1E4315D87");

            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.ActualCash).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.ExpectedCash).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.StartingCash).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSales).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Shifts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Shifts__UserID__6E01572D");
        });

        modelBuilder.Entity<Spot>(entity =>
        {
            entity.HasKey(e => e.SpotId).HasName("PK__Spots__61645FE7B6D3A839");

            entity.Property(e => e.SpotId).HasColumnName("SpotID");
            entity.Property(e => e.SpotName).HasMaxLength(100);
            entity.Property(e => e.SpotTypeId).HasColumnName("SpotTypeID");

            entity.HasOne(d => d.SpotType).WithMany(p => p.Spots)
                .HasForeignKey(d => d.SpotTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Spots_SpotTypes");
        });

        modelBuilder.Entity<SpotType>(entity =>
        {
            entity.HasKey(e => e.SpotTypeId).HasName("PK__SpotType__37A6B6A939C6C814");

            entity.Property(e => e.SpotTypeId).HasColumnName("SpotTypeID");
            entity.Property(e => e.Image).IsUnicode(false);
            entity.Property(e => e.PricePerHour).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SpotTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACAF3AF7E5");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4651017CF").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
