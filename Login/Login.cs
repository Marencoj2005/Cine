using System.Net.Http;
using System.Net.Http.Json;
namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = global::Login.Properties.Resources.usuario;
            pictureBox2.Image = global::Login.Properties.Resources.contraseña;
        }
        public class LoginResponse
        {
            public bool Autenticado { get; set; }
            public string NombreUsuario { get; set; } = "";
            public string Rol { get; set; } = "";
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string usuario = TxbNombre.Text.Trim();
            string contraseña = TbxContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            BtnLogin.Enabled = false;

            try
            {
                using HttpClient cliente = new HttpClient();

                var datos = new
                {
                    NombreUsuario = usuario,
                    Password = contraseña
                };

                // Cambiar el puerto si es necesario
                string url = "https://localhost:7136/api/Auth/Login";

                HttpResponseMessage respuesta =
                    await cliente.PostAsJsonAsync(url, datos);

                if (respuesta.StatusCode ==
                    System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos");
                    return;
                }

                if (!respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Error al iniciar sesión. Código: " +
                        (int)respuesta.StatusCode);
                    return;
                }

                LoginResponse? resultado =
                    await respuesta.Content
                        .ReadFromJsonAsync<LoginResponse>();

                if (resultado == null || !resultado.Autenticado)
                {
                    MessageBox.Show("No se pudo iniciar sesión");
                    return;
                }

                if (resultado.Rol == "Administrador")
                {
                    MessageBox.Show("Bienvenido, administrador");
                    // Aqui se abre el menu
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }

                else if (resultado.Rol == "Usuario")
                {
                    MessageBox.Show("Bienvenido, " +
                        resultado.NombreUsuario);

                    /*
                     * Juan, aqui tienes que abrir la locacion de la web aunque es un misterio para mi como realmente
                     * se puede abrir desde aqui, lo descubriremos mas adelante :)
                     */
                }
                else
                {
                    MessageBox.Show("Rol no reconocido");
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar con la API. ");
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("La solicitud tardo demasiado tiempo.");
            }
            catch (System.Text.Json.JsonException)
            {
                MessageBox.Show("La API devolvio una respuesta no válida.");
            }
            finally
            {
                BtnLogin.Enabled = true;
            }
        }
    }
}
