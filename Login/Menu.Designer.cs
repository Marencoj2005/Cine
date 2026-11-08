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
            novedadesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
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
            panel2.Size = new Size(1025, 56);
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
            panel1.Size = new Size(1025, 44);
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
            btnrestaurar.Location = new Point(917, 9);
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
            btnminimizar.Location = new Point(867, 9);
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
            btnSalir.Location = new Point(965, 9);
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
            label1.Location = new Point(261, 5);
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
            menuCine.Items.AddRange(new ToolStripItem[] { imagen, actualizaciónToolStripMenuItem, novedadesToolStripMenuItem, cerrarSesiónToolStripMenuItem, salirToolStripMenuItem, salirToolStripMenuItem1 });
            menuCine.Location = new Point(0, 56);
            menuCine.Name = "menuCine";
            menuCine.Padding = new Padding(6, 12, 0, 12);
            menuCine.Size = new Size(1025, 60);
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
            actualizaciónToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            actualizaciónToolStripMenuItem.Size = new Size(95, 36);
            actualizaciónToolStripMenuItem.Text = "Consulta";
            // 
            // novedadesToolStripMenuItem
            // 
            novedadesToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            novedadesToolStripMenuItem.Size = new Size(133, 36);
            novedadesToolStripMenuItem.Text = "Actualización";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(123, 36);
            cerrarSesiónToolStripMenuItem.Text = "Novedades ";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.ForeColor = Color.FromArgb(212, 175, 55);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(132, 36);
            salirToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.ForeColor = Color.FromArgb(212, 175, 55);
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(59, 36);
            salirToolStripMenuItem1.Text = "Salir";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 735);
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
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}