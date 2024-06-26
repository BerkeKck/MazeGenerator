using System;
using System.Collections.Generic;

namespace NorthWind.Api.Entities.Entities;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
