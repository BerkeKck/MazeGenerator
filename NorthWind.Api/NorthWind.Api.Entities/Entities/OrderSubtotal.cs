using System;
using System.Collections.Generic;

namespace NorthWind.Api.Entities.Entities;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
