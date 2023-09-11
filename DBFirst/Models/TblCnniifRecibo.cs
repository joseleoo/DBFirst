using System;
using System.Collections.Generic;

namespace DBFirst.Models;

public partial class TblCnniifRecibo
{
    public int Idreca { get; set; }

    public string TipReca { get; set; } = null!;

    public int NroReca { get; set; }

    public string? CodSucu { get; set; }

    public string Codempre { get; set; } = null!;

    public DateTime? FecReca { get; set; }

    public decimal Totreca { get; set; }

    public string? TipoReg { get; set; }

    public string? NitTercero { get; set; }

    public string? Concepto { get; set; }

    public string? CodOtros1 { get; set; }

    public string? CueOtros1 { get; set; }

    public decimal Valorotro1 { get; set; }

    public string? CodOtros2 { get; set; }

    public string? CueOtros2 { get; set; }

    public decimal Valorotro2 { get; set; }

    public string? TipRecaCruce { get; set; }

    public int NroRecaCruce { get; set; }

    public string? CodSucuCruce { get; set; }

    public bool Conta { get; set; }

    public DateTime? FecConta { get; set; }

    public bool Impre { get; set; }

    public DateTime? FecImpre { get; set; }

    public string? CodUsuCrea { get; set; }

    public string? CodUsuMod { get; set; }

    public DateTime? FecModif { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FecEstado { get; set; }
}
