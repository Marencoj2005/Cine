using System;
using System.Collections.Generic;

namespace CineAPI.Models;

public partial class Empleado
{
    public int CodEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public double? Salario { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
