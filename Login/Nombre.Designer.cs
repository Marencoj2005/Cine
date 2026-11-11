namespace Login
{
    partial class Nombre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nombre));
            panel1 = new Panel();
            panel2 = new Panel();
            btnsalir2 = new Button();
            lbltitulo = new Label();
            dataGridNombre = new DataGridView();
            groupBoxNombre = new GroupBox();
            CbxNombre = new ComboBox();
            btnbuscar = new Button();
            lblBuscar = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNombre).BeginInit();
            groupBoxNombre.SuspendLayout();
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
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 42, 74);
            panel2.Controls.Add(btnsalir2);
            panel2.Controls.Add(lbltitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 1;
            // 
            // btnsalir2
            // 
            btnsalir2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsalir2.BackColor = Color.FromArgb(158, 0, 0);
            btnsalir2.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
            btnsalir2.FlatAppearance.BorderSize = 2;
            btnsalir2.FlatStyle = FlatStyle.Flat;
            btnsalir2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir2.ForeColor = Color.White;
            btnsalir2.Location = new Point(751, 12);
            btnsalir2.Name = "btnsalir2";
            btnsalir2.Size = new Size(37, 24);
            btnsalir2.TabIndex = 9;
            btnsalir2.Text = "X";
            btnsalir2.UseVisualStyleBackColor = false;
            btnsalir2.Click += btnsalir2_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Dock = DockStyle.Top;
            lbltitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = Color.FromArgb(212, 175, 55);
            lbltitulo.Location = new Point(0, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(114, 32);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Nombre";
            // 
            // dataGridNombre
            // 
            dataGridNombre.BackgroundColor = Color.FromArgb(30, 41, 59);
            dataGridNombre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNombre.Location = new Point(107, 187);
            dataGridNombre.Name = "dataGridNombre";
            dataGridNombre.RowHeadersWidth = 51;
            dataGridNombre.Size = new Size(659, 233);
            dataGridNombre.TabIndex = 6;
            // 
            // groupBoxNombre
            // 
            groupBoxNombre.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxNombre.Controls.Add(CbxNombre);
            groupBoxNombre.Controls.Add(btnbuscar);
            groupBoxNombre.Controls.Add(lblBuscar);
            groupBoxNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxNombre.ForeColor = Color.White;
            groupBoxNombre.Location = new Point(107, 107);
            groupBoxNombre.Name = "groupBoxNombre";
            groupBoxNombre.Size = new Size(659, 71);
            groupBoxNombre.TabIndex = 5;
            groupBoxNombre.TabStop = false;
            groupBoxNombre.Text = "Consulta por Nombre";
            // 
            // CbxNombre
            // 
            CbxNombre.FormattingEnabled = true;
            CbxNombre.Location = new Point(250, 28);
            CbxNombre.Margin = new Padding(3, 4, 3, 4);
            CbxNombre.Name = "CbxNombre";
            CbxNombre.Size = new Size(210, 26);
            CbxNombre.TabIndex = 3;
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
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(54, 35);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(161, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por Nombre:";
            // 
            // Nombre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 451);
            Controls.Add(dataGridNombre);
            Controls.Add(groupBoxNombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Nombre";
            Text = "Nombre";
            Activated += Nombre_Activated;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridNombre).EndInit();
            groupBoxNombre.ResumeLayout(false);
            groupBoxNombre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbltitulo;
        private Button btnsalir2;
        private DataGridView dataGridNombre;
        private GroupBox groupBoxNombre;
        private Button btnbuscar;
        private Label lblBuscar;
        private ComboBox CbxNombre;
    }
}