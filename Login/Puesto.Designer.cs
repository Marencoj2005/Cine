namespace Login
{
    partial class Puesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puesto));
            panel1 = new Panel();
            panel2 = new Panel();
            btnsalir3 = new Button();
            lbltitulo = new Label();
            dataGridPuesto = new DataGridView();
            groupBoxPuesto = new GroupBox();
            CbxPuesto = new ComboBox();
            btnbuscar = new Button();
            lblBuscar = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPuesto).BeginInit();
            groupBoxPuesto.SuspendLayout();
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
            panel2.Controls.Add(btnsalir3);
            panel2.Controls.Add(lbltitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 44);
            panel2.TabIndex = 1;
            // 
            // btnsalir3
            // 
            btnsalir3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnsalir3.BackColor = Color.FromArgb(158, 0, 0);
            btnsalir3.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55);
            btnsalir3.FlatAppearance.BorderSize = 2;
            btnsalir3.FlatStyle = FlatStyle.Flat;
            btnsalir3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir3.ForeColor = Color.White;
            btnsalir3.Location = new Point(751, 12);
            btnsalir3.Name = "btnsalir3";
            btnsalir3.Size = new Size(37, 24);
            btnsalir3.TabIndex = 10;
            btnsalir3.Text = "X";
            btnsalir3.UseVisualStyleBackColor = false;
            btnsalir3.Click += btnsalir3_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Dock = DockStyle.Top;
            lbltitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = Color.FromArgb(212, 175, 55);
            lbltitulo.Location = new Point(0, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(103, 32);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "Puesto";
            // 
            // dataGridPuesto
            // 
            dataGridPuesto.BackgroundColor = Color.FromArgb(30, 41, 59);
            dataGridPuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPuesto.Location = new Point(106, 176);
            dataGridPuesto.Name = "dataGridPuesto";
            dataGridPuesto.RowHeadersWidth = 51;
            dataGridPuesto.Size = new Size(659, 233);
            dataGridPuesto.TabIndex = 8;
            // 
            // groupBoxPuesto
            // 
            groupBoxPuesto.BackColor = Color.FromArgb(30, 41, 59);
            groupBoxPuesto.Controls.Add(CbxPuesto);
            groupBoxPuesto.Controls.Add(btnbuscar);
            groupBoxPuesto.Controls.Add(lblBuscar);
            groupBoxPuesto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxPuesto.ForeColor = Color.White;
            groupBoxPuesto.Location = new Point(106, 97);
            groupBoxPuesto.Name = "groupBoxPuesto";
            groupBoxPuesto.Size = new Size(659, 71);
            groupBoxPuesto.TabIndex = 7;
            groupBoxPuesto.TabStop = false;
            groupBoxPuesto.Text = "Consulta por Puesto";
            // 
            // CbxPuesto
            // 
            CbxPuesto.FormattingEnabled = true;
            CbxPuesto.Location = new Point(256, 25);
            CbxPuesto.Margin = new Padding(3, 4, 3, 4);
            CbxPuesto.Name = "CbxPuesto";
            CbxPuesto.Size = new Size(220, 26);
            CbxPuesto.TabIndex = 9;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.FromArgb(30, 41, 50);
            btnbuscar.FlatAppearance.BorderColor = Color.Olive;
            btnbuscar.FlatAppearance.BorderSize = 2;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.FromArgb(212, 175, 55);
            btnbuscar.Location = new Point(533, 20);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 37);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(54, 35);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(154, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar por Puesto:";
            // 
            // Puesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(dataGridPuesto);
            Controls.Add(groupBoxPuesto);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Puesto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puesto";
            Activated += Puesto_Activated;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPuesto).EndInit();
            groupBoxPuesto.ResumeLayout(false);
            groupBoxPuesto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbltitulo;
        private Button btnsalir3;
        private DataGridView dataGridPuesto;
        private GroupBox groupBoxPuesto;
        private Button btnbuscar;
        private Label lblBuscar;
        private ComboBox CbxPuesto;
    }
}