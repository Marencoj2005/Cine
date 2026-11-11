using System;
using System.Collections.Generic;

namespace CineAPI.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Edad { get; set; }

    public int? IdUsuarioFk { get; set; }

    public virtual Usuario? IdUsuarioFkNavigation { get; set; }

    public virtual ICollection<Reservacion> Reservacions { get; set; } = new List<Reservacion>();
}
