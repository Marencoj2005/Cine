using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DatabaseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ProbarConexion")]
        public async Task<IActionResult> ProbarConexion()
        {
            string conexion = _configuration.GetConnectionString("LocalConnection");

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(conexion))
                {
                    await connection.OpenAsync();

                    return Ok(new
                    {
                        conectado = true,
                        mensaje = "Conexión exitosa con SQL Server"
                    });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    conectado = false,
                    mensaje = ex.Message
                });
            }
        }
    }
}
