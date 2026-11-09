using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ReservasController : ControllerBase
{
    // Endpoint: GET /api/reservas/consulta?cliente=Juan&puesto=A1
    [HttpGet("consulta")]
    public IActionResult ConsultarReserva([FromQuery] string cliente = "", [FromQuery] string puesto = "")
    {
        // Aquí la API hace un SELECT a la tabla 'Reservaciones'
        // Si es Blazor quien llama, le devuelves los datos en formato JSON (ReservaDto)

        // Logica de filtro...
        return Ok(new { Mensaje = "Aquí viaja la lista de reservas en JSON" });
    }
}
