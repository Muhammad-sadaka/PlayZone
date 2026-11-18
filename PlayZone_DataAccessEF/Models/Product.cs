using System;
using System.Collections.Generic;

namespace PlayZone_DataAccessEF.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public virtual ICollection<ReservationProduct> ReservationProducts { get; set; } = new List<ReservationProduct>();
}
