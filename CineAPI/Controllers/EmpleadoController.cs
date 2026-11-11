using CineAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class EmpleadosController : ControllerBase
{
    private readonly CineContext _context;

    public EmpleadosController(CineContext context) => _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EmpleadoDto>>> GetEmpleados(
        [FromQuery] string? nombre,
        [FromQuery] string? apellido,
        [FromQuery] int? codEmpleado)
    {
        var query = _context.Empleados.AsQueryable();

        if (!string.IsNullOrWhiteSpace(nombre))
            query = query.Where(e => e.Nombre != null && e.Nombre.Contains(nombre));

        if (!string.IsNullOrWhiteSpace(apellido))
            query = query.Where(e => e.Apellido != null && e.Apellido.Contains(apellido));

        if (codEmpleado.HasValue)
            query = query.Where(e => e.CodEmpleado == codEmpleado.Value);

        var resultado = await query
            .OrderBy(e => e.CodEmpleado)
            .Select(e => new EmpleadoDto
            {
                CodEmpleado = e.CodEmpleado,
                Nombre = e.Nombre,
                Apellido = e.Apellido,
                Salario = e.Salario
            })
            .ToListAsync();

        return Ok(resultado);
    }
}

public class EmpleadoDto
{
    public int CodEmpleado { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public double? Salario { get; set; }
}