using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<SpotType> SpotTypes { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=.;Database=PlayZone;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // جلب مسار المجلد الحالي وتحديد ملف appsettings.json مباشرة
            var jsonPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(jsonPath, optional: false, reloadOnChange: true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SharedDTOs.ReservationDTO>().HasNoKey();

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.SpotTypeId).HasColumnName("SpotTypeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("money");

            entity.HasOne(d => d.SpotType).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.SpotTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reservations_SpotTypes");
        });

        modelBuilder.Entity<SpotType>(entity =>
        {
            entity.Property(e => e.SpotTypeId).HasColumnName("SpotTypeID");
            entity.Property(e => e.Image).HasMaxLength(100);
            entity.Property(e => e.PricePerHour).HasColumnType("money");
            entity.Property(e => e.SpotTypeName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
