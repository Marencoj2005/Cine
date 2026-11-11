using System;
using System.Collections.Generic;

namespace CineAPI.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreUsu { get; set; }

    public string? Contra { get; set; }

    public string? RolSistema { get; set; }

    public int? CodEmpleadoFkUsua { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Empleado? CodEmpleadoFkUsuaNavigation { get; set; }
}
