using System.Net.Http;
using System.Net.Http.Json;
namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = global::Login.Properties.Resources.pngwing_com;
            pictureBox2.Image = global::Login.Properties.Resources.pngwing_com__1_;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class LoginResponse
        {
            public string Token { get; set; }
            public string NombreUsuario { get; set; }
            public string Rol { get; set; }
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string usuario = TxbNombre.Text.Trim();
            string contrasena = TbxContraseña.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    var datos = new
                    {
                        nombreUsuario = usuario,
                        contrasena = contrasena
                    };

                    var respuesta = await cliente.PostAsJsonAsync(
                        "https://localhost:7000/api/auth/login",
                        datos
                    );

                    if (respuesta.IsSuccessStatusCode)
                    {
                        var resultado = await respuesta.Content
                            .ReadFromJsonAsync<LoginResponse>();

                        // Aquí recibimos el token y el rol.
                        if (resultado.Rol == "Administrador")
                        {
                            MessageBox.Show("Bienvenido al sistema");

                            // Aquí abriremos el formulario principal.
                        }
                        else
                        {
                            MessageBox.Show("No tienes permisos de administrador");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("No fue posible conectar con el servidor");
                }
            }
        }
    }
}
