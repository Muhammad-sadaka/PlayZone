using System;
using System.Collections.Generic;

namespace PlayZone_DataAccessEF.Models;

public partial class Shift
{
    public int ShiftId { get; set; }

    public int? UserId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public decimal StartingCash { get; set; }

    public decimal TotalSales { get; set; }

    public decimal ExpectedCash { get; set; }

    public decimal? ActualCash { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual User? User { get; set; }
}
