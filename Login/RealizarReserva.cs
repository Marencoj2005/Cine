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
        string conexion = "Server=172.29.68.36,1433;Database=Cine;User Id=sa;Password=Juan2005@;TrustServerCertificate=True";
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

        }

        private void btnpago_Click(object sender, EventArgs e)
        {

        }

        private void txsilla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
