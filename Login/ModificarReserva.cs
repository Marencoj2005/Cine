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

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void txcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
