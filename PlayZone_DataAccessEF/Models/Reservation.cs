using System;
using System.Collections.Generic;

namespace PlayZone_DataAccessEF.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public string CustomerName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public TimeSpan? Period { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? SessionRevenue { get; set; }

    public decimal? CafeteriaRevenue { get; set; }

    public int? SpotId { get; set; }

    public int ShiftId { get; set; }

    public virtual ICollection<ReservationProduct> ReservationProducts { get; set; } = new List<ReservationProduct>();

    public virtual Shift Shift { get; set; } = null!;

    public virtual Spot? Spot { get; set; }
}
