namespace Login
{
    partial class CancelarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarReserva));
            panel1 = new Panel();
            panel2 = new Panel();
            btnsalir5 = new Button();
            lbltitulo = new Label();
            groupBoxCancelarReserva = new GroupBox();
            comboBoxCancelarReserva = new ComboBox();
            btnbuscar = new Button();
            lblBuscar = new Label();
            groupBoxDatosReservaParaCancelar = new GroupBox();
            dataGridCancelar = new DataGridView();
            btncancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxCancelarReserva.SuspendLayout();
            groupBoxDatosReservaParaCancelar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCancelar).BeginInit();
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
            panel2.Controls.Add(btnsalir5);
            panel2.Controls.Add(lbltitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 1;
            // 
            // btnsalir5
            // 
            btnsalir5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsalir5.BackColor = Color.FromArgb(158, 0, 0);
            btnsalir5.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
            btnsalir5.FlatAppearance.BorderSize = 2;
            btnsalir5.FlatStyle = FlatStyle.Flat;
            btnsalir5.Font = new Font("Berlin Sans FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir5.ForeColor = Color.White;
            btnsalir5.Location = new Point(751, 8);
            btnsalir5.Name = "btnsalir5";
            btnsalir5.Size = new Size(37, 24);
            btnsalir5.TabIndex = 10;
            btnsalir5.Text = "X";
            btnsalir5.UseVisualStyleBackColor = false;
            btnsalir5.Click += btnsalir5_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Dock = DockStyle.Top;
            lbltitulo.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = Color.FromArgb(212, 175, 55);
            lbltitulo.Location = new Point(0, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(218, 31);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Cancelar Reserva";
            // 
            // groupBoxCancelarReserva
            // 
            groupBoxCancelarReserva.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxCancelarReserva.Controls.Add(comboBoxCancelarReserva);
            groupBoxCancelarReserva.Controls.Add(btnbuscar);
            groupBoxCancelarReserva.Controls.Add(lblBuscar);
            groupBoxCancelarReserva.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxCancelarReserva.ForeColor = Color.White;
            groupBoxCancelarReserva.Location = new Point(84, 82);
            groupBoxCancelarReserva.Name = "groupBoxCancelarReserva";
            groupBoxCancelarReserva.Size = new Size(659, 71);
            groupBoxCancelarReserva.TabIndex = 9;
            groupBoxCancelarReserva.TabStop = false;
            groupBoxCancelarReserva.Text = "Buscar Reservación";
            groupBoxCancelarReserva.Enter += groupBoxCancelarReserva_Enter;
            // 
            // comboBoxCancelarReserva
            // 
            comboBoxCancelarReserva.FormattingEnabled = true;
            comboBoxCancelarReserva.Location = new Point(227, 31);
            comboBoxCancelarReserva.Name = "comboBoxCancelarReserva";
            comboBoxCancelarReserva.Size = new Size(251, 25);
            comboBoxCancelarReserva.TabIndex = 3;
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
            // groupBoxDatosReservaParaCancelar
            // 
            groupBoxDatosReservaParaCancelar.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxDatosReservaParaCancelar.Controls.Add(dataGridCancelar);
            groupBoxDatosReservaParaCancelar.Controls.Add(btncancelar);
            groupBoxDatosReservaParaCancelar.Font = new Font("Berlin Sans FB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDatosReservaParaCancelar.ForeColor = Color.White;
            groupBoxDatosReservaParaCancelar.Location = new Point(84, 159);
            groupBoxDatosReservaParaCancelar.Name = "groupBoxDatosReservaParaCancelar";
            groupBoxDatosReservaParaCancelar.Size = new Size(659, 310);
            groupBoxDatosReservaParaCancelar.TabIndex = 14;
            groupBoxDatosReservaParaCancelar.TabStop = false;
            groupBoxDatosReservaParaCancelar.Text = "Datos de Reserva";
            // 
            // dataGridCancelar
            // 
            dataGridCancelar.BackgroundColor = Color.White;
            dataGridCancelar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCancelar.Location = new Point(18, 33);
            dataGridCancelar.Name = "dataGridCancelar";
            dataGridCancelar.RowHeadersWidth = 51;
            dataGridCancelar.Size = new Size(621, 201);
            dataGridCancelar.TabIndex = 12;
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(30, 41, 50);
            btncancelar.FlatAppearance.BorderColor = Color.Olive;
            btncancelar.FlatAppearance.BorderSize = 2;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.FromArgb(212, 175, 55);
            btncancelar.Location = new Point(483, 254);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(144, 29);
            btncancelar.TabIndex = 11;
            btncancelar.Text = "Cancelar Reserva";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // CancelarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 503);
            Controls.Add(groupBoxDatosReservaParaCancelar);
            Controls.Add(groupBoxCancelarReserva);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelarReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancelarReserva";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxCancelarReserva.ResumeLayout(false);
            groupBoxCancelarReserva.PerformLayout();
            groupBoxDatosReservaParaCancelar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCancelar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbltitulo;
        private Button btnsalir5;
        private GroupBox groupBoxCancelarReserva;
        private Button btnbuscar;
        private Label lblBuscar;
        private GroupBox groupBoxDatosReservaParaCancelar;
        private Button btncancelar;
        private ComboBox comboBoxCancelarReserva;
        private DataGridView dataGridCancelar;
    }
}