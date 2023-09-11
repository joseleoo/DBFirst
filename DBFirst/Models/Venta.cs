using System;
using System.Collections.Generic;

namespace DBFirst.Models;

public partial class Venta
{
    public string Categoria { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public decimal? Venta1 { get; set; }
}
