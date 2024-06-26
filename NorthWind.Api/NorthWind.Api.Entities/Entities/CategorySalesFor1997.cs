using System;
using System.Collections.Generic;

namespace NorthWind.Api.Entities.Entities;

public partial class CategorySalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public decimal? CategorySales { get; set; }
}
