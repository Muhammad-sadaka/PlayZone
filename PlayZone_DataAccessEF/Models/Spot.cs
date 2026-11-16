using System;
using System.Collections.Generic;

namespace PlayZone_DataAccessEF.Models;

public partial class Spot
{
    public int SpotId { get; set; }

    public string SpotName { get; set; } = null!;

    public int SpotTypeId { get; set; }

    public bool Active { get; set; }

    public virtual SpotType SpotType { get; set; } = null!;
}
