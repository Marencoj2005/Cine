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
        //Depende del computador tienes que cambiar el Server = ....
        //att Samuel
        string conexion = @"Server=DESKTOP-HKP8GGD\\SQLEXPRESS;
                    Database=Cine;
                    Trusted_Connection=True;
                    TrustServerCertificate=True;";

        public Puesto()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void btnsalir3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                    SELECT Id_Cliente, Nombre + ' ' + Apellido AS NombreCompleto
                    FROM Cliente";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, con);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    CbxPuesto.DisplayMember = "NombreCompleto";
                    CbxPuesto.ValueMember = "Id_Cliente";
                    CbxPuesto.DataSource = tabla;

                    CbxPuesto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                SELECT C.Nombre,C.Apellido,R.Numero_silla,R.Pelicula, R.Fecha_Reserva,R.Metodo_Pago
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
