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
    public partial class CancelarReserva : Form
    {
        string conexion = @"Server=.\DBD2025;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        public CancelarReserva()
        {
            InitializeComponent();
            CargarReservas();
        }

        private void btnsalir5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargar los códigos de reserva disponibles en el ComboBox
        private void CargarReservas()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                    SELECT Codigo_Reserva
                    FROM Reservacion
                    ORDER BY Codigo_Reserva";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    comboBoxCancelarReserva.DisplayMember = "Codigo_Reserva";
                    comboBoxCancelarReserva.ValueMember = "Codigo_Reserva";
                    comboBoxCancelarReserva.DataSource = tabla;

                    comboBoxCancelarReserva.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas: " + ex.Message);
            }
        }

        private void groupBoxCancelarReserva_Enter(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxCancelarReserva.SelectedValue == null || comboBoxCancelarReserva.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona un código de reserva");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                    SELECT R.Codigo_Reserva, C.Nombre, C.Apellido, R.Numero_silla, R.Pelicula, R.Fecha_Reserva, R.Metodo_Pago
                    FROM Reservacion R
                    INNER JOIN Cliente C ON R.Id_Cliente_FK = C.Id_Cliente
                    WHERE R.Codigo_Reserva = @CodigoReserva";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@CodigoReserva", comboBoxCancelarReserva.SelectedValue
                    );

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Asegúrate de cambiar 'dataGridCancelar' por el nombre real de tu DataGridView si es diferente
                    dataGridCancelar.DataSource = tabla;

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró la reserva");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (comboBoxCancelarReserva.SelectedValue == null || comboBoxCancelarReserva.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona la reserva que deseas cancelar");
                return;
            }

            var confirmacion = MessageBox.Show("¿Estás segura de que deseas eliminar esta reserva?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conexion))
                    {
                        string query = "DELETE FROM Reservacion WHERE Codigo_Reserva = @CodigoReserva";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@CodigoReserva", comboBoxCancelarReserva.SelectedValue);

                        con.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                            {
                            MessageBox.Show("Reserva cancelada con éxito.");
                            CargarReservas(); // Recargamos el ComboBox para actualizar la lista
                            dataGridCancelar.DataSource = null; // Limpiamos la grilla
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cancelar la reserva.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
