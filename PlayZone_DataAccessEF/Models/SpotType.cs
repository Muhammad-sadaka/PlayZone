using System;
using System.Collections.Generic;

namespace PlayZone_DataAccessEF.Models;

public partial class SpotType
{
    public int? SpotTypeId { get; set; }

    public string SpotTypeName { get; set; } = null!;

    public decimal? PricePerHour { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
