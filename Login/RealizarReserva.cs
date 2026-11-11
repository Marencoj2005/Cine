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
    public partial class RealizarReserva : Form
    {
        string conexion = @"Server=.\DBD2025;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        public RealizarReserva()
        {
            InitializeComponent();
            btnguardar.Enabled = false;
            btnpago.Enabled = false;
        }

        private void btnsalir6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBoxGestonReserva_Enter(object sender, EventArgs e)
        {
            btnRealizarReserva.Enabled = false;
            btnpago.Enabled = false;
        }

        private void btnRealizarReserva_Click(object sender, EventArgs e)
        {
            btnguardar.Enabled = true;
            btnpago.Enabled = false;


        }

        private void butnVenderTiquete_Click(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
            btnpago.Enabled = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txsilla.Text) ||
                string.IsNullOrWhiteSpace(txfechareserva.Text) ||
                string.IsNullOrWhiteSpace(txpelicula.Text) ||
                string.IsNullOrWhiteSpace(txmetodopago.Text) ||
                string.IsNullOrWhiteSpace(txcliente.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();

                    //VALIDAR SI EL ASIENTO YA ESTÁ OCUPADO PARA ESA PELÍCULA Y FECHA
                    string queryValidacion = @"
            SELECT COUNT(*) 
            FROM Reservacion 
            WHERE Numero_silla = @Silla 
              AND Pelicula = @Pelicula 
              AND Fecha_Reserva = @Fecha";

                    using (SqlCommand cmdVal = new SqlCommand(queryValidacion, con))
                    {
                        cmdVal.Parameters.AddWithValue("@Silla", txsilla.Text.Trim());
                        cmdVal.Parameters.AddWithValue("@Pelicula", txpelicula.Text.Trim());
                        cmdVal.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(txfechareserva.Text.Trim()));

                        int existe = (int)cmdVal.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("¡Ese asiento ya está reservado para esta película en esta fecha! Elige otro.", "Asiento Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Detiene el proceso y no guarda nada
                        }
                    }

                    //SI NO EXISTE, PROCEDEMOS A INSERTAR LA RESERVA / VENDIENDO EL TIQUETE
                    string queryInsert = @"
            INSERT INTO Reservacion (Numero_silla, Fecha_Reserva, Pelicula, Metodo_Pago, Id_Cliente_FK)
            VALUES (@Silla, @Fecha, @Pelicula, @Pago, @ClienteId)";

                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, con))
                    {
                        cmdInsert.Parameters.AddWithValue("@Silla", txsilla.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(txfechareserva.Text.Trim()));
                        cmdInsert.Parameters.AddWithValue("@Pelicula", txpelicula.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@Pago", txmetodopago.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@ClienteId", Convert.ToInt32(txcliente.Text.Trim()));

                        int filasAfectadas = cmdInsert.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Registro guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la reserva.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar o guardar: " + ex.Message);
            }
        }

        private void btnpago_Click(object sender, EventArgs e)
        {
            //Validar que los campos obligatorios estén llenos
            if (string.IsNullOrWhiteSpace(txsilla.Text) ||
                string.IsNullOrWhiteSpace(txfechareserva.Text) ||
                string.IsNullOrWhiteSpace(txpelicula.Text) ||
                string.IsNullOrWhiteSpace(txmetodopago.Text) ||
                string.IsNullOrWhiteSpace(txcliente.Text))
            {
                MessageBox.Show("Por favor completa los datos de la silla, película, método de pago y cliente.");
                return;
            }

            //Validación de que el método de pago sea válido
            string metodoPago = txmetodopago.Text.Trim();
            if (metodoPago != "Efectivo" && metodoPago != "Tarjeta" && metodoPago != "Nequi" && metodoPago != "Daviplata")
            {
                MessageBox.Show("Método de pago no válido. Escribe: Efectivo, Tarjeta, Nequi o Daviplata.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();

                    //VALIDAR SI EL ASIENTO YA ESTÁ OCUPADO PARA ESA PELÍCULA Y FECHA
                    string queryValidacion = @"
            SELECT COUNT(*) 
            FROM Reservacion 
            WHERE Numero_silla = @Silla 
              AND Pelicula = @Pelicula 
              AND Fecha_Reserva = @Fecha";

                    using (SqlCommand cmdVal = new SqlCommand(queryValidacion, con))
                    {
                        cmdVal.Parameters.AddWithValue("@Silla", txsilla.Text.Trim());
                        cmdVal.Parameters.AddWithValue("@Pelicula", txpelicula.Text.Trim());
                        cmdVal.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(txfechareserva.Text.Trim()));

                        int existe = (int)cmdVal.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("¡Ese asiento ya está ocupado para esta película en esta fecha! No se puede procesar el pago.", "Asiento Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Detiene el proceso y no guarda nada
                        }
                    }

                    //SI NO EXISTE, PROCEDEMOS A INSERTAR LA VENTA/RESERVA
                    string queryInsert = @"
            INSERT INTO Reservacion (Numero_silla, Fecha_Reserva, Pelicula, Metodo_Pago, Id_Cliente_FK)
            VALUES (@Silla, @Fecha, @Pelicula, @Pago, @ClienteId)";

                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, con))
                    {
                        cmdInsert.Parameters.AddWithValue("@Silla", txsilla.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(txfechareserva.Text.Trim()));
                        cmdInsert.Parameters.AddWithValue("@Pelicula", txpelicula.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@Pago", metodoPago);
                        cmdInsert.Parameters.AddWithValue("@ClienteId", Convert.ToInt32(txcliente.Text.Trim()));

                        int filasAfectadas = cmdInsert.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            // Mensaje de éxito enfocado en la venta del tiquete
                            MessageBox.Show(
                                $"¡Tiquete vendido y pago procesado con éxito!\n\n" +
                                $"Película: {txpelicula.Text.Trim()}\n" +
                                $"Silla: {txsilla.Text.Trim()}\n" +
                                $"Método: {metodoPago}",    
                                "Venta Exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo procesar la venta del tiquete.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message);
            }
        }

        //Método auxiliar para limpiar las cajas después de una venta exitosa
        private void LimpiarCampos()
        {
            txsilla.Clear();
            txfechareserva.Clear();
            txpelicula.Clear();
            txmetodopago.Clear();
            txcliente.Clear();
        }

    }
}
