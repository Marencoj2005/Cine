using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Login
{
    public partial class Puesto : Form
    {
        //string conexion = @"Server=DESKTOP-HKP8GGD\SQLEXPRESS;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        string conexion = "Server=172.29.68.36,1433;Database=Cine;User Id=sa;Password=TuPass123!;TrustServerCertificate=True;";

        public Puesto()
        {
            InitializeComponent();
            CargarPuestos();
        }

        private void btnsalir3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargar los asientos en el ComboBox
        private void CargarPuestos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                    SELECT DISTINCT Numero_silla
                    FROM Reservacion
                    ORDER BY Numero_silla";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, con);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    CbxPuesto.DisplayMember = "Numero_silla";
                    CbxPuesto.ValueMember = "Numero_silla";
                    CbxPuesto.DataSource = tabla;

                    CbxPuesto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar puestos: " + ex.Message);
            }
        }

        // Buscar el asiento seleccionado
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbxPuesto.Text))
            {
                MessageBox.Show("Selecciona un asiento");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                    SELECT C.Nombre,C.Apellido,R.Numero_silla,R.Pelicula,R.Fecha_Reserva,R.Metodo_Pago
                    FROM Reservacion R
                    INNER JOIN Cliente C ON R.Id_Cliente_FK = C.Id_Cliente
                    WHERE R.Numero_silla = @Puesto";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, con);

                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@Puesto", CbxPuesto.Text.Trim()
                    );

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridPuesto.DataSource = tabla;

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró el asiento");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
