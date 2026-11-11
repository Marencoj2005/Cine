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
        string conexion = "Server=172.29.68.36,1433;Database=Cine;User Id=sa;Password=Juan2005@;TrustServerCertificate=True;";

        public Nombre()
        {
            InitializeComponent();
        }

        private void btnsalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CbxNombre.Text))
            {
                MessageBox.Show("Ingresa el nombre de un cliente");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    string consulta = @"
                    SELECT C.Nombre,C.Apellido,R.Numero_silla,R.Pelicula,R.Fecha_Reserva,R.Metodo_Pago
                    FROM Cliente C
                    INNER JOIN Reservacion R ON C.Id_Cliente = R.Id_Cliente_FK
                    WHERE C.Nombre LIKE @Nombre";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, con);

                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@Nombre", "%" + CbxNombre.Text.Trim() + "%"
                    );

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridNombre.DataSource = tabla;

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No se encontraron reservaciones para ese cliente"
                        );
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
