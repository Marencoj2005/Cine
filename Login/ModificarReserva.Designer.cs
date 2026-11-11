namespace Login
{
    partial class ModificarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarReserva));
            panel1 = new Panel();
            panel2 = new Panel();
            btnsalir4 = new Button();
            lbltitulo = new Label();
            groupBoxModificarReserva = new GroupBox();
            comboBoxcodigo = new ComboBox();
            btnbuscar = new Button();
            lblBuscar = new Label();
            groupBoxmodificar = new GroupBox();
            btnmodificar = new Button();
            txcliente = new TextBox();
            label6 = new Label();
            txmetodopago = new TextBox();
            label4 = new Label();
            txpelicula = new TextBox();
            txfechareserva = new TextBox();
            txsilla = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxModificarReserva.SuspendLayout();
            groupBoxmodificar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 175, 55);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 42, 74);
            panel2.Controls.Add(btnsalir4);
            panel2.Controls.Add(lbltitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 1;
            // 
            // btnsalir4
            // 
            btnsalir4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsalir4.BackColor = Color.FromArgb(158, 0, 0);
            btnsalir4.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
            btnsalir4.FlatAppearance.BorderSize = 2;
            btnsalir4.FlatStyle = FlatStyle.Flat;
            btnsalir4.Font = new Font("Berlin Sans FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir4.ForeColor = Color.White;
            btnsalir4.Location = new Point(751, 12);
            btnsalir4.Name = "btnsalir4";
            btnsalir4.Size = new Size(37, 24);
            btnsalir4.TabIndex = 10;
            btnsalir4.Text = "X";
            btnsalir4.UseVisualStyleBackColor = false;
            btnsalir4.Click += btnsalir4_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Dock = DockStyle.Top;
            lbltitulo.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = Color.FromArgb(212, 175, 55);
            lbltitulo.Location = new Point(0, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(223, 31);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Modificar Reserva";
            // 
            // groupBoxModificarReserva
            // 
            groupBoxModificarReserva.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxModificarReserva.Controls.Add(comboBoxcodigo);
            groupBoxModificarReserva.Controls.Add(btnbuscar);
            groupBoxModificarReserva.Controls.Add(lblBuscar);
            groupBoxModificarReserva.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxModificarReserva.ForeColor = Color.White;
            groupBoxModificarReserva.Location = new Point(44, 77);
            groupBoxModificarReserva.Name = "groupBoxModificarReserva";
            groupBoxModificarReserva.Size = new Size(716, 71);
            groupBoxModificarReserva.TabIndex = 12;
            groupBoxModificarReserva.TabStop = false;
            groupBoxModificarReserva.Text = "Buscar Reservación";
            // 
            // comboBoxcodigo
            // 
            comboBoxcodigo.FormattingEnabled = true;
            comboBoxcodigo.Location = new Point(225, 32);
            comboBoxcodigo.Name = "comboBoxcodigo";
            comboBoxcodigo.Size = new Size(254, 25);
            comboBoxcodigo.TabIndex = 3;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.FromArgb(30, 41, 50);
            btnbuscar.FlatAppearance.BorderColor = Color.Olive;
            btnbuscar.FlatAppearance.BorderSize = 2;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.FromArgb(212, 175, 55);
            btnbuscar.Location = new Point(533, 28);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(54, 34);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(142, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por Código:";
            // 
            // groupBoxmodificar
            // 
            groupBoxmodificar.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxmodificar.Controls.Add(btnmodificar);
            groupBoxmodificar.Controls.Add(txcliente);
            groupBoxmodificar.Controls.Add(label6);
            groupBoxmodificar.Controls.Add(txmetodopago);
            groupBoxmodificar.Controls.Add(label4);
            groupBoxmodificar.Controls.Add(txpelicula);
            groupBoxmodificar.Controls.Add(txfechareserva);
            groupBoxmodificar.Controls.Add(txsilla);
            groupBoxmodificar.Controls.Add(label3);
            groupBoxmodificar.Controls.Add(label2);
            groupBoxmodificar.Controls.Add(label1);
            groupBoxmodificar.Font = new Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxmodificar.ForeColor = Color.White;
            groupBoxmodificar.Location = new Point(44, 154);
            groupBoxmodificar.Name = "groupBoxmodificar";
            groupBoxmodificar.Size = new Size(716, 391);
            groupBoxmodificar.TabIndex = 13;
            groupBoxmodificar.TabStop = false;
            groupBoxmodificar.Text = "Ingresar Datos de la Reserva";
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.FromArgb(30, 41, 50);
            btnmodificar.FlatAppearance.BorderColor = Color.Olive;
            btnmodificar.FlatAppearance.BorderSize = 3;
            btnmodificar.FlatStyle = FlatStyle.Flat;
            btnmodificar.ForeColor = Color.FromArgb(212, 175, 55);
            btnmodificar.Location = new Point(523, 179);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(148, 40);
            btnmodificar.TabIndex = 12;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = false;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // txcliente
            // 
            txcliente.Location = new Point(262, 309);
            txcliente.Name = "txcliente";
            txcliente.Size = new Size(186, 26);
            txcliente.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 12F);
            label6.Location = new Point(66, 312);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 8;
            label6.Text = "Cliente:";
            // 
            // txmetodopago
            // 
            txmetodopago.Location = new Point(262, 246);
            txmetodopago.Name = "txmetodopago";
            txmetodopago.Size = new Size(186, 26);
            txmetodopago.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 12F);
            label4.Location = new Point(66, 249);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 6;
            label4.Text = "Método de Pago:";
            // 
            // txpelicula
            // 
            txpelicula.Location = new Point(262, 187);
            txpelicula.Name = "txpelicula";
            txpelicula.Size = new Size(186, 26);
            txpelicula.TabIndex = 5;
            // 
            // txfechareserva
            // 
            txfechareserva.Location = new Point(262, 123);
            txfechareserva.Name = "txfechareserva";
            txfechareserva.Size = new Size(183, 26);
            txfechareserva.TabIndex = 4;
            // 
            // txsilla
            // 
            txsilla.Location = new Point(262, 61);
            txsilla.Name = "txsilla";
            txsilla.Size = new Size(183, 26);
            txsilla.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 12F);
            label3.Location = new Point(66, 190);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 2;
            label3.Text = "Pelicula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F);
            label2.Location = new Point(67, 126);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Reserva:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.Location = new Point(66, 64);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 0;
            label1.Text = "Número de Silla:";
            // 
            // ModificarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 588);
            Controls.Add(groupBoxmodificar);
            Controls.Add(groupBoxModificarReserva);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarReserva";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxModificarReserva.ResumeLayout(false);
            groupBoxModificarReserva.PerformLayout();
            groupBoxmodificar.ResumeLayout(false);
            groupBoxmodificar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbltitulo;
        private Button btnsalir4;
        private GroupBox groupBoxModificarReserva;
        private Button btnbuscar;
        private Label lblBuscar;
        private GroupBox groupBoxmodificar;
        private Button btnmodificar;
        private TextBox txcliente;
        private Label label6;
        private TextBox txmetodopago;
        private Label label4;
        private TextBox txpelicula;
        private TextBox txfechareserva;
        private TextBox txsilla;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxcodigo;
    }
}