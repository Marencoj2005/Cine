using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineAPI.Controllers
{
    [Route("api/[controller]")] // Esto se traduce a: api/Auth
    [ApiController]
    public class AuthController : ControllerBase
    {
        // La suma total del Endpoint será: POST https://localhost:7136/api/Auth/login esta es mi ruta local, en azure se debe corregir esto
        //mientras miren su puerto local y reemplazelo este por el que ustedes manejen para ejecutar
        [HttpPost("login")]
        public IActionResult Login([FromBody] object datosDeLogin)
        {
            // Aquí irá tu lógica para validar el usuario en la base de datos
            return Ok(new { Exito = true, Rol = "Administrador" });
        }
    }
}