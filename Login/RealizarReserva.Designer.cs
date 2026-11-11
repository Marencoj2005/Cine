namespace Login
{
    partial class RealizarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarReserva));
            panel1 = new Panel();
            panel2 = new Panel();
            btnsalir6 = new Button();
            lbltitulo = new Label();
            groupBoxIngresarCliente = new GroupBox();
            btnpago = new Button();
            btnguardar = new Button();
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
            butnVenderTiquete = new Button();
            btnRealizarReserva = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxIngresarCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 175, 55);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 40);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 42, 74);
            panel2.Controls.Add(btnsalir6);
            panel2.Controls.Add(lbltitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 33);
            panel2.TabIndex = 1;
            // 
            // btnsalir6
            // 
            btnsalir6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsalir6.BackColor = Color.FromArgb(158, 0, 0);
            btnsalir6.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
            btnsalir6.FlatAppearance.BorderSize = 2;
            btnsalir6.FlatStyle = FlatStyle.Flat;
            btnsalir6.Font = new Font("Berlin Sans FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir6.ForeColor = Color.White;
            btnsalir6.Location = new Point(657, 9);
            btnsalir6.Margin = new Padding(3, 2, 3, 2);
            btnsalir6.Name = "btnsalir6";
            btnsalir6.Size = new Size(32, 18);
            btnsalir6.TabIndex = 11;
            btnsalir6.Text = "X";
            btnsalir6.UseVisualStyleBackColor = false;
            btnsalir6.Click += btnsalir6_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Dock = DockStyle.Top;
            lbltitulo.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = Color.FromArgb(212, 175, 55);
            lbltitulo.Location = new Point(0, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(349, 24);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Realizar Reserva y Venta de Tiquete";
            // 
            // groupBoxIngresarCliente
            // 
            groupBoxIngresarCliente.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxIngresarCliente.Controls.Add(btnpago);
            groupBoxIngresarCliente.Controls.Add(btnguardar);
            groupBoxIngresarCliente.Controls.Add(txcliente);
            groupBoxIngresarCliente.Controls.Add(label6);
            groupBoxIngresarCliente.Controls.Add(txmetodopago);
            groupBoxIngresarCliente.Controls.Add(label4);
            groupBoxIngresarCliente.Controls.Add(txpelicula);
            groupBoxIngresarCliente.Controls.Add(txfechareserva);
            groupBoxIngresarCliente.Controls.Add(txsilla);
            groupBoxIngresarCliente.Controls.Add(label3);
            groupBoxIngresarCliente.Controls.Add(label2);
            groupBoxIngresarCliente.Controls.Add(label1);
            groupBoxIngresarCliente.Font = new Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxIngresarCliente.ForeColor = Color.White;
            groupBoxIngresarCliente.Location = new Point(35, 134);
            groupBoxIngresarCliente.Margin = new Padding(3, 2, 3, 2);
            groupBoxIngresarCliente.Name = "groupBoxIngresarCliente";
            groupBoxIngresarCliente.Padding = new Padding(3, 2, 3, 2);
            groupBoxIngresarCliente.Size = new Size(626, 293);
            groupBoxIngresarCliente.TabIndex = 7;
            groupBoxIngresarCliente.TabStop = false;
            groupBoxIngresarCliente.Text = "Ingresar Datos de la Reserva";
            // 
            // btnpago
            // 
            btnpago.BackColor = Color.FromArgb(30, 41, 50);
            btnpago.FlatAppearance.BorderColor = Color.Olive;
            btnpago.FlatAppearance.BorderSize = 3;
            btnpago.FlatStyle = FlatStyle.Flat;
            btnpago.ForeColor = Color.FromArgb(212, 175, 55);
            btnpago.Location = new Point(447, 159);
            btnpago.Margin = new Padding(3, 2, 3, 2);
            btnpago.Name = "btnpago";
            btnpago.Size = new Size(130, 30);
            btnpago.TabIndex = 13;
            btnpago.Text = "Procesar Pago";
            btnpago.UseVisualStyleBackColor = false;
            btnpago.Click += btnpago_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(30, 41, 50);
            btnguardar.FlatAppearance.BorderColor = Color.Olive;
            btnguardar.FlatAppearance.BorderSize = 3;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.FromArgb(212, 175, 55);
            btnguardar.Location = new Point(447, 106);
            btnguardar.Margin = new Padding(3, 2, 3, 2);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(130, 30);
            btnguardar.TabIndex = 12;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txcliente
            // 
            txcliente.Location = new Point(229, 232);
            txcliente.Margin = new Padding(3, 2, 3, 2);
            txcliente.Name = "txcliente";
            txcliente.Size = new Size(163, 22);
            txcliente.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB", 12F);
            label6.Location = new Point(58, 234);
            label6.Name = "label6";
            label6.Size = new Size(56, 18);
            label6.TabIndex = 8;
            label6.Text = "Cliente:";
            // 
            // txmetodopago
            // 
            txmetodopago.Location = new Point(229, 184);
            txmetodopago.Margin = new Padding(3, 2, 3, 2);
            txmetodopago.Name = "txmetodopago";
            txmetodopago.Size = new Size(163, 22);
            txmetodopago.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 12F);
            label4.Location = new Point(58, 187);
            label4.Name = "label4";
            label4.Size = new Size(121, 18);
            label4.TabIndex = 6;
            label4.Text = "Método de Pago:";
            // 
            // txpelicula
            // 
            txpelicula.Location = new Point(229, 140);
            txpelicula.Margin = new Padding(3, 2, 3, 2);
            txpelicula.Name = "txpelicula";
            txpelicula.Size = new Size(163, 22);
            txpelicula.TabIndex = 5;
            // 
            // txfechareserva
            // 
            txfechareserva.Location = new Point(229, 92);
            txfechareserva.Margin = new Padding(3, 2, 3, 2);
            txfechareserva.Name = "txfechareserva";
            txfechareserva.Size = new Size(161, 22);
            txfechareserva.TabIndex = 4;
            // 
            // txsilla
            // 
            txsilla.Location = new Point(229, 46);
            txsilla.Margin = new Padding(3, 2, 3, 2);
            txsilla.Name = "txsilla";
            txsilla.Size = new Size(161, 22);
            txsilla.TabIndex = 3;
            txsilla.TextChanged += txsilla_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 12F);
            label3.Location = new Point(58, 142);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 2;
            label3.Text = "Pelicula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F);
            label2.Location = new Point(59, 94);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Reserva:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.Location = new Point(58, 48);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 0;
            label1.Text = "Número de Silla:";
            // 
            // butnVenderTiquete
            // 
            butnVenderTiquete.BackColor = Color.FromArgb(30, 41, 50);
            butnVenderTiquete.FlatAppearance.BorderColor = Color.Olive;
            butnVenderTiquete.FlatAppearance.BorderSize = 3;
            butnVenderTiquete.FlatStyle = FlatStyle.Flat;
            butnVenderTiquete.ForeColor = Color.FromArgb(212, 175, 55);
            butnVenderTiquete.Location = new Point(370, 28);
            butnVenderTiquete.Margin = new Padding(3, 2, 3, 2);
            butnVenderTiquete.Name = "butnVenderTiquete";
            butnVenderTiquete.Size = new Size(130, 30);
            butnVenderTiquete.TabIndex = 14;
            butnVenderTiquete.Text = "Vender  Tiquete";
            butnVenderTiquete.UseVisualStyleBackColor = false;
            butnVenderTiquete.Click += butnVenderTiquete_Click;
            // 
            // btnRealizarReserva
            // 
            btnRealizarReserva.BackColor = Color.FromArgb(30, 41, 50);
            btnRealizarReserva.FlatAppearance.BorderColor = Color.Olive;
            btnRealizarReserva.FlatAppearance.BorderSize = 3;
            btnRealizarReserva.FlatStyle = FlatStyle.Flat;
            btnRealizarReserva.ForeColor = Color.FromArgb(212, 175, 55);
            btnRealizarReserva.Location = new Point(170, 28);
            btnRealizarReserva.Margin = new Padding(3, 2, 3, 2);
            btnRealizarReserva.Name = "btnRealizarReserva";
            btnRealizarReserva.Size = new Size(130, 30);
            btnRealizarReserva.TabIndex = 13;
            btnRealizarReserva.Text = "Realizar Reserva";
            btnRealizarReserva.UseVisualStyleBackColor = false;
            btnRealizarReserva.Click += btnRealizarReserva_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(30, 41, 59);
            groupBox1.Controls.Add(butnVenderTiquete);
            groupBox1.Controls.Add(btnRealizarReserva);
            groupBox1.Font = new Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(35, 58);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(626, 72);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de Reserva y Venta ";
            // 
            // RealizarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 466);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxIngresarCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RealizarReserva";
            Text = "RealizarReserva";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxIngresarCliente.ResumeLayout(false);
            groupBoxIngresarCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbltitulo;
        private Button btnsalir6;
        private GroupBox groupBoxIngresarCliente;
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
        private Button btnpago;
        private Button btnguardar;
        private Button butnVenderTiquete;
        private Button btnRealizarReserva;
        private GroupBox groupBox1;
    }
}