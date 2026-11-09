namespace Login
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel2 = new Panel();
            panel1 = new Panel();
            btnrestaurar = new Button();
            btnminimizar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            menuCine = new MenuStrip();
            imagen = new ToolStripMenuItem();
            actualizaciónToolStripMenuItem = new ToolStripMenuItem();
            porPuestoToolStripMenuItem = new ToolStripMenuItem();
            porNombreToolStripMenuItem = new ToolStripMenuItem();
            novedadesToolStripMenuItem = new ToolStripMenuItem();
            cancelarReservaciónToolStripMenuItem = new ToolStripMenuItem();
            cambiarDatosDeReservaciónToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            realizarReservaciónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            menuCine.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 175, 55);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 56);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 42, 74);
            panel1.Controls.Add(btnrestaurar);
            panel1.Controls.Add(btnminimizar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 44);
            panel1.TabIndex = 0;
            // 
            // btnrestaurar
            // 
            btnrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnrestaurar.BackColor = Color.FromArgb(212, 175, 55);
            btnrestaurar.FlatAppearance.BorderColor = Color.Olive;
            btnrestaurar.FlatAppearance.BorderSize = 2;
            btnrestaurar.FlatStyle = FlatStyle.Flat;
            btnrestaurar.Font = new Font("Berlin Sans FB", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrestaurar.ForeColor = Color.White;
            btnrestaurar.Location = new Point(732, 9);
            btnrestaurar.Name = "btnrestaurar";
            btnrestaurar.Size = new Size(37, 24);
            btnrestaurar.TabIndex = 3;
            btnrestaurar.Text = "❐";
            btnrestaurar.UseVisualStyleBackColor = false;
            btnrestaurar.Click += btnrestaurar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnminimizar.BackColor = Color.FromArgb(212, 175, 55);
            btnminimizar.FlatAppearance.BorderColor = Color.Olive;
            btnminimizar.FlatAppearance.BorderSize = 2;
            btnminimizar.FlatStyle = FlatStyle.Flat;
            btnminimizar.Font = new Font("Berlin Sans FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnminimizar.ForeColor = Color.White;
            btnminimizar.Location = new Point(682, 9);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(39, 24);
            btnminimizar.TabIndex = 2;
            btnminimizar.Text = "-";
            btnminimizar.UseVisualStyleBackColor = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(158, 0, 0);
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Berlin Sans FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(780, 9);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(37, 24);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(212, 175, 55);
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(503, 31);
            label1.TabIndex = 0;
            label1.Text = "La Lata 3D y HD - Plataforma de Gestión";
            // 
            // menuCine
            // 
            menuCine.BackColor = Color.Black;
            menuCine.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuCine.ImageScalingSize = new Size(30, 32);
            menuCine.Items.AddRange(new ToolStripItem[] { imagen, actualizaciónToolStripMenuItem, novedadesToolStripMenuItem, cerrarSesiónToolStripMenuItem, salirToolStripMenuItem });
            menuCine.Location = new Point(0, 56);
            menuCine.Name = "menuCine";
            menuCine.Padding = new Padding(6, 12, 0, 12);
            menuCine.Size = new Size(840, 60);
            menuCine.TabIndex = 1;
            menuCine.Text = "menuStrip1";
            // 
            // imagen
            // 
            imagen.BackColor = Color.Black;
            imagen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imagen.Font = new Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imagen.ForeColor = Color.FromArgb(212, 175, 55);
            imagen.Image = (Image)resources.GetObject("imagen.Image");
            imagen.Name = "imagen";
            imagen.Size = new Size(44, 36);
            imagen.Text = ".";
            // 
            // actualizaciónToolStripMenuItem
            // 
            actualizaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porPuestoToolStripMenuItem, porNombreToolStripMenuItem });
            actualizaciónToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            actualizaciónToolStripMenuItem.Size = new Size(95, 36);
            actualizaciónToolStripMenuItem.Text = "Consulta";
            // 
            // porPuestoToolStripMenuItem
            // 
            porPuestoToolStripMenuItem.BackColor = Color.Black;
            porPuestoToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            porPuestoToolStripMenuItem.Name = "porPuestoToolStripMenuItem";
            porPuestoToolStripMenuItem.Size = new Size(196, 28);
            porPuestoToolStripMenuItem.Text = "Por Puesto";
            porPuestoToolStripMenuItem.Click += porPuestoToolStripMenuItem_Click;
            // 
            // porNombreToolStripMenuItem
            // 
            porNombreToolStripMenuItem.BackColor = Color.Black;
            porNombreToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            porNombreToolStripMenuItem.Size = new Size(196, 28);
            porNombreToolStripMenuItem.Text = "Por Nombre";
            porNombreToolStripMenuItem.Click += porNombreToolStripMenuItem_Click;
            // 
            // novedadesToolStripMenuItem
            // 
            novedadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cancelarReservaciónToolStripMenuItem, cambiarDatosDeReservaciónToolStripMenuItem });
            novedadesToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            novedadesToolStripMenuItem.Size = new Size(133, 36);
            novedadesToolStripMenuItem.Text = "Actualización";
            // 
            // cancelarReservaciónToolStripMenuItem
            // 
            cancelarReservaciónToolStripMenuItem.BackColor = Color.Black;
            cancelarReservaciónToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            cancelarReservaciónToolStripMenuItem.Name = "cancelarReservaciónToolStripMenuItem";
            cancelarReservaciónToolStripMenuItem.Size = new Size(349, 28);
            cancelarReservaciónToolStripMenuItem.Text = "Cancelar Reservación";
            cancelarReservaciónToolStripMenuItem.Click += cancelarReservaciónToolStripMenuItem_Click;
            // 
            // cambiarDatosDeReservaciónToolStripMenuItem
            // 
            cambiarDatosDeReservaciónToolStripMenuItem.BackColor = Color.Black;
            cambiarDatosDeReservaciónToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            cambiarDatosDeReservaciónToolStripMenuItem.Name = "cambiarDatosDeReservaciónToolStripMenuItem";
            cambiarDatosDeReservaciónToolStripMenuItem.Size = new Size(349, 28);
            cambiarDatosDeReservaciónToolStripMenuItem.Text = "Cambiar Datos de Reservación";
            cambiarDatosDeReservaciónToolStripMenuItem.Click += cambiarDatosDeReservaciónToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { realizarReservaciónToolStripMenuItem });
            cerrarSesiónToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(123, 36);
            cerrarSesiónToolStripMenuItem.Text = "Novedades ";
            // 
            // realizarReservaciónToolStripMenuItem
            // 
            realizarReservaciónToolStripMenuItem.BackColor = Color.Black;
            realizarReservaciónToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            realizarReservaciónToolStripMenuItem.Name = "realizarReservaciónToolStripMenuItem";
            realizarReservaciónToolStripMenuItem.Size = new Size(413, 28);
            realizarReservaciónToolStripMenuItem.Text = "Realizar Reservación y Vender Tiquete";
            realizarReservaciónToolStripMenuItem.Click += realizarReservaciónToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(59, 36);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Transparent;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 116);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(840, 591);
            panelContenedor.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 707);
            Controls.Add(panelContenedor);
            Controls.Add(menuCine);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuCine.ResumeLayout(false);
            menuCine.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button btnSalir;
        private Button btnrestaurar;
        private Button btnminimizar;
        private MenuStrip menuCine;
        private ToolStripMenuItem imagen;
        private ToolStripMenuItem actualizaciónToolStripMenuItem;
        private ToolStripMenuItem novedadesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem porPuestoToolStripMenuItem;
        private ToolStripMenuItem porNombreToolStripMenuItem;
        private Panel panelContenedor;
        private ToolStripMenuItem cancelarReservaciónToolStripMenuItem;
        private ToolStripMenuItem cambiarDatosDeReservaciónToolStripMenuItem;
        private ToolStripMenuItem realizarReservaciónToolStripMenuItem;
    }
}