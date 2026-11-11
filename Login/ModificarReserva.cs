using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class ModificarReserva : Form
    {
        string conexion = @"Server=.\DBD2025;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        public ModificarReserva()
        {
            InitializeComponent();
            CargarCodigosReserva();
        }

        private void btnsalir4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCodigosReserva()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = "SELECT Codigo_Reserva FROM Reservacion ORDER BY Codigo_Reserva";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    comboBoxcodigo.DisplayMember = "Codigo_Reserva";
                    comboBoxcodigo.ValueMember = "Codigo_Reserva";
                    comboBoxcodigo.DataSource = tabla;
                    comboBoxcodigo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar códigos: " + ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxcodigo.SelectedValue == null || comboBoxcodigo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un código de reserva");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                    SELECT R.Numero_silla, R.Fecha_Reserva, R.Pelicula, R.Metodo_Pago, (C.Nombre + ' ' + C.Apellido) AS NombreCliente
                    FROM Reservacion R
                    INNER JOIN Cliente C ON R.Id_Cliente_FK = C.Id_Cliente
                    WHERE R.Codigo_Reserva = @Cod";

                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@Cod", comboBoxcodigo.SelectedValue);

                    con.Open();
                    SqlDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        txsilla.Text = lector["Numero_silla"].ToString();
                        txfechareserva.Text = Convert.ToDateTime(lector["Fecha_Reserva"]).ToString("yyyy-MM-dd");
                        txpelicula.Text = lector["Pelicula"].ToString();
                        txmetodopago.Text = lector["Metodo_Pago"].ToString();
                        txcliente.Text = lector["NombreCliente"].ToString(); // Solo lectura o informativo
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (comboBoxcodigo.SelectedValue == null || comboBoxcodigo.SelectedIndex == -1)
            {
                MessageBox.Show("Primero selecciona y busca una reserva para modificar.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string query = @"
                    UPDATE Reservacion 
                    SET Numero_silla = @Silla, 
                        Fecha_Reserva = @Fecha, 
                        Pelicula = @Pelicula, 
                        Metodo_Pago = @Pago 
                    WHERE Codigo_Reserva = @Cod";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Silla", txsilla.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(txfechareserva.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Pelicula", txpelicula.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pago", txmetodopago.Text.Trim());
                    cmd.Parameters.AddWithValue("@Cod", comboBoxcodigo.SelectedValue);

                    con.Open();
                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("¡Reserva modificada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar la modificación.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
    }
}
