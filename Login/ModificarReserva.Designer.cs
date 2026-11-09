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
            groupBoxDatosReserva = new GroupBox();
            btnmodificar = new Button();
            dataGridDatosReservaModificar = new DataGridView();
            groupBoxModificarReserva = new GroupBox();
            btnbuscar = new Button();
            txcodigo = new TextBox();
            lblBuscar = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxDatosReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDatosReservaModificar).BeginInit();
            groupBoxModificarReserva.SuspendLayout();
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
            // groupBoxDatosReserva
            // 
            groupBoxDatosReserva.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxDatosReserva.Controls.Add(btnmodificar);
            groupBoxDatosReserva.Controls.Add(dataGridDatosReservaModificar);
            groupBoxDatosReserva.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDatosReserva.ForeColor = Color.White;
            groupBoxDatosReserva.Location = new Point(65, 154);
            groupBoxDatosReserva.Name = "groupBoxDatosReserva";
            groupBoxDatosReserva.Size = new Size(659, 310);
            groupBoxDatosReserva.TabIndex = 13;
            groupBoxDatosReserva.TabStop = false;
            groupBoxDatosReserva.Text = "Datos de Reserva";
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.FromArgb(30, 41, 50);
            btnmodificar.FlatAppearance.BorderColor = Color.Olive;
            btnmodificar.FlatAppearance.BorderSize = 2;
            btnmodificar.FlatStyle = FlatStyle.Flat;
            btnmodificar.ForeColor = Color.FromArgb(212, 175, 55);
            btnmodificar.Location = new Point(483, 254);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(144, 29);
            btnmodificar.TabIndex = 11;
            btnmodificar.Text = "Modificar Reserva";
            btnmodificar.UseVisualStyleBackColor = false;
            // 
            // dataGridDatosReservaModificar
            // 
            dataGridDatosReservaModificar.BackgroundColor = Color.White;
            dataGridDatosReservaModificar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDatosReservaModificar.Location = new Point(10, 41);
            dataGridDatosReservaModificar.Name = "dataGridDatosReservaModificar";
            dataGridDatosReservaModificar.RowHeadersWidth = 51;
            dataGridDatosReservaModificar.Size = new Size(634, 194);
            dataGridDatosReservaModificar.TabIndex = 10;
            // 
            // groupBoxModificarReserva
            // 
            groupBoxModificarReserva.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxModificarReserva.Controls.Add(btnbuscar);
            groupBoxModificarReserva.Controls.Add(txcodigo);
            groupBoxModificarReserva.Controls.Add(lblBuscar);
            groupBoxModificarReserva.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxModificarReserva.ForeColor = Color.White;
            groupBoxModificarReserva.Location = new Point(65, 77);
            groupBoxModificarReserva.Name = "groupBoxModificarReserva";
            groupBoxModificarReserva.Size = new Size(659, 71);
            groupBoxModificarReserva.TabIndex = 12;
            groupBoxModificarReserva.TabStop = false;
            groupBoxModificarReserva.Text = "Buscar Reservación";
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
            // 
            // txcodigo
            // 
            txcodigo.Location = new Point(234, 33);
            txcodigo.Name = "txcodigo";
            txcodigo.Size = new Size(244, 24);
            txcodigo.TabIndex = 1;
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
            // ModificarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 503);
            Controls.Add(groupBoxDatosReserva);
            Controls.Add(groupBoxModificarReserva);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarReserva";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxDatosReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDatosReservaModificar).EndInit();
            groupBoxModificarReserva.ResumeLayout(false);
            groupBoxModificarReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbltitulo;
        private Button btnsalir4;
        private GroupBox groupBoxDatosReserva;
        private Button btnmodificar;
        private DataGridView dataGridDatosReservaModificar;
        private GroupBox groupBoxModificarReserva;
        private Button btnbuscar;
        private TextBox txcodigo;
        private Label lblBuscar;
    }
}