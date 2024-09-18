using System;
using System.Collections.Generic;

namespace CuongDepTrai2.Models;

public partial class Flower
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Color { get; set; }

    public decimal? Price { get; set; }
}
