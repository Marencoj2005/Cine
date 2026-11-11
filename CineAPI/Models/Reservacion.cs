using System;
using System.Collections.Generic;

namespace CineAPI.Models;

public partial class Reservacion
{
    public int CodigoReserva { get; set; }

    public string? NumeroSilla { get; set; }

    public DateOnly? FechaReserva { get; set; }

    public string? Pelicula { get; set; }

    public string? MetodoPago { get; set; }

    public int? IdClienteFk { get; set; }

    public virtual Cliente? IdClienteFkNavigation { get; set; }
}
