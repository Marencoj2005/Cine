using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
namespace CineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public class LoginRequest
        {
            public string NombreUsuario { get; set; } = "";
            public string Password { get; set; } = "";
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(
            [FromBody] LoginRequest datos)
        {
            if (string.IsNullOrWhiteSpace(datos.NombreUsuario)
                || string.IsNullOrEmpty(datos.Password))
            {
                return BadRequest(new
                {
                    mensaje = "Ingrese usuario y contraseña"
                });
            }

            string hash = Convert.ToHexString(
                SHA256.HashData(
                    Encoding.UTF8.GetBytes(datos.Password)
                )
            );

            string? cadena = _configuration
                .GetConnectionString("LocalConnection");

            if (string.IsNullOrEmpty(cadena))
                return StatusCode(500);

            try
            {
                using var conexion = new SqlConnection(cadena);
                await conexion.OpenAsync();

                string consulta = @"
                    SELECT Nombre_Usu, Rol_sistema
                    FROM Usuarios
                    WHERE Nombre_Usu = @usuario
                    AND Contra = @hash";

                using var comando =
                    new SqlCommand(consulta, conexion);

                comando.Parameters.Add(
                    "@usuario",
                    System.Data.SqlDbType.VarChar, 100
                ).Value = datos.NombreUsuario;

                comando.Parameters.Add(
                    "@hash",
                    System.Data.SqlDbType.VarChar, 64
                ).Value = hash;

                using var lector =
                    await comando.ExecuteReaderAsync();

                if (await lector.ReadAsync())
                {
                    string usuario =
                        lector["Nombre_Usu"].ToString()!;

                    string rol =
                        lector["Rol_sistema"].ToString()!;

                    return Ok(new
                    {
                        autenticado = true,
                        nombreUsuario = usuario,
                        rol = rol
                    });
                }

                return Unauthorized(new
                {
                    autenticado = false,
                    mensaje = "Usuario o contraseña incorrectos"
                });
            }
            catch (SqlException)
            {
                return StatusCode(500, new
                {
                    mensaje = "Error al consultar la base de datos"
                });
            }
        }
    }
}

