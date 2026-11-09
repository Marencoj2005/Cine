using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnrestaurar.Text = "❐"; // Cambia el ícono a restaurar
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnrestaurar.Text = "☐"; // Cambia el ícono a maximizar
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void porPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Clear();
            }

            // Creamos el formulario de puesto
            Puesto frm = new Puesto();

            // Le quitamos los bordes de ventana para que parezca parte del diseño
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill; // Hace que llene todo el panel

            // Lo agregamos al panel del formulario principal y lo mostramos
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Add(frm);
            }

            frm.Show();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (panelContenedor != null)
            {
                panelContenedor.Controls.Clear();
            }

            // Creamos el formulario de nombre
            Nombre frm = new Nombre();

            // Le quitamos los bordes de ventana para que parezca parte del diseño
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill; // Hace que llene todo el panel

            // Lo agregamos al panel del formulario principal y lo mostramos
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Add(frm);
            }

            frm.Show();
        }

        private void cancelarReservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Clear();
            }

            // Creamos el formulario de puesto
            CancelarReserva frm = new CancelarReserva();

            // Le quitamos los bordes de ventana para que parezca parte del diseño
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill; // Hace que llene todo el panel

            // Lo agregamos al panel del formulario principal y lo mostramos
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Add(frm);
            }

            frm.Show();
        }

        private void cambiarDatosDeReservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Clear();
            }

            // Creamos el formulario de puesto
            ModificarReserva frm = new ModificarReserva();

            // Le quitamos los bordes de ventana para que parezca parte del diseño
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill; // Hace que llene todo el panel

            // Lo agregamos al panel del formulario principal y lo mostramos
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Add(frm);
            }

            frm.Show();
        }

        private void realizarReservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Clear();
            }

            // Creamos el formulario de la reserva
            RealizarReserva frm = new RealizarReserva();

            // Le quitamos los bordes de ventana para que parezca parte del diseño
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill; // Hace que llene todo el panel

            // Lo agregamos al panel del formulario principal y lo mostramos
            if (panelContenedor != null)
            {
                panelContenedor.Controls.Add(frm);
            }

            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
