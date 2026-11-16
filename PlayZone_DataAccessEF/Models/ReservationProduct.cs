using System;
using System.Collections.Generic;

namespace PlayZone_DataAccessEF.Models;

public partial class ReservationProduct
{
    public int OrderProductId { get; set; }

    public int? ReservationId { get; set; }

    public int? ProductId { get; set; }

    public int Quantity { get; set; }

    public decimal TotalPrice { get; set; }

    public string? Name { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Reservation? Reservation { get; set; }
}
