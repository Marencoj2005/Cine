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

    public partial class Nombre : Form
    {
        // Cambiar el servidor según el computador
        string conexion = @"Server=.\DBD2025;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";

        public Nombre()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void btnsalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para cargar los clientes en el ComboBox
        private void CargarClientes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
            SELECT Id_Cliente, Nombre + ' ' + Apellido AS NombreCompleto
            FROM Cliente
            ORDER BY Nombre";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    CbxNombre.DisplayMember = "NombreCompleto";
                    CbxNombre.ValueMember = "Id_Cliente";
                    CbxNombre.DataSource = tabla;

                    CbxNombre.SelectedIndex = -1; // Comienza vacío
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un cliente del ComboBox
            if (CbxNombre.SelectedValue == null || CbxNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un cliente de la lista");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    // Consultamos filtrando directamente por el Id_Cliente que tiene guardado el ValueMember
                    string consulta = @"
            SELECT C.Nombre, C.Apellido, R.Numero_silla, R.Pelicula, R.Fecha_Reserva, R.Metodo_Pago
            FROM Cliente C
            INNER JOIN Reservacion R ON C.Id_Cliente = R.Id_Cliente_FK
            WHERE C.Id_Cliente = @IdCliente";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, con);

                    // Pasamos el ID exacto del cliente seleccionado
                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@IdCliente", CbxNombre.SelectedValue
                    );

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridNombre.DataSource = tabla;

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron reservaciones para ese cliente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Nombre_Activated(object sender, EventArgs e)
        {
            CargarClientes();
            dataGridNombre.DataSource = null;
        }
    }
}
