namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            TxbNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TbxContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            BtnLogin = new Button();
            BtnSalir = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // TxbNombre
            // 
            TxbNombre.Anchor = AnchorStyles.None;
            TxbNombre.BackColor = Color.FromArgb(35, 35, 35);
            TxbNombre.BorderStyle = BorderStyle.FixedSingle;
            TxbNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TxbNombre.ForeColor = Color.White;
            TxbNombre.Location = new Point(56, 61);
            TxbNombre.Multiline = true;
            TxbNombre.Name = "TxbNombre";
            TxbNombre.Size = new Size(220, 28);
            TxbNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 193, 7);
            label1.Location = new Point(44, 12);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre Usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 193, 7);
            label2.Location = new Point(46, 12);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // TbxContraseña
            // 
            TbxContraseña.Anchor = AnchorStyles.None;
            TbxContraseña.BackColor = Color.FromArgb(35, 35, 35);
            TbxContraseña.BorderStyle = BorderStyle.FixedSingle;
            TbxContraseña.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TbxContraseña.ForeColor = Color.White;
            TbxContraseña.Location = new Point(56, 161);
            TbxContraseña.Multiline = true;
            TbxContraseña.Name = "TbxContraseña";
            TbxContraseña.PasswordChar = '*';
            TbxContraseña.Size = new Size(220, 28);
            TbxContraseña.TabIndex = 2;
            //
            // pictureBox1
            //
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            //
            // pictureBox2
            //
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(131, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 29);
            label3.TabIndex = 8;
            label3.Text = "Acceso al Sistema";
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.BackColor = Color.FromArgb(220, 25, 25);
            BtnLogin.FlatStyle = FlatStyle.Popup;
            BtnLogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.FromArgb(255, 193, 7);
            BtnLogin.Location = new Point(63, 210);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(205, 30);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "Iniciar Sesión";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.None;
            BtnSalir.BackColor = Color.FromArgb(60, 60, 60);
            BtnSalir.FlatStyle = FlatStyle.Popup;
            BtnSalir.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.FromArgb(255, 193, 7);
            BtnSalir.Location = new Point(63, 260);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(205, 30);
            BtnSalir.TabIndex = 10;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Controls.Add(BtnSalir, 0, 5);
            tableLayoutPanel1.Controls.Add(BtnLogin, 0, 4);
            tableLayoutPanel1.Controls.Add(TbxContraseña, 0, 3);
            tableLayoutPanel1.Controls.Add(TxbNombre, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Location = new Point(59, 258);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(332, 321);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.1901836F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.8098145F));
            tableLayoutPanel6.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel6.Controls.Add(label2, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 103);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(326, 44);
            tableLayoutPanel6.TabIndex = 15;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6760559F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.3239441F));
            tableLayoutPanel5.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel5.Controls.Add(label1, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(326, 44);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(84, 303);
            label5.Name = "label5";
            label5.Size = new Size(163, 15);
            label5.TabIndex = 16;
            label5.Text = "Versión 1.0 © La Lata 3D y HD";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(900, 600);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 24);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(450, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 600);
            panel1.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.666667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60.1666679F));
            tableLayoutPanel4.Size = new Size(450, 600);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 177);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(444, 58);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(105, 35);
            label4.Name = "label4";
            label4.Size = new Size(233, 17);
            label4.TabIndex = 9;
            label4.Text = "Bienvenido a su plataforma de gestión";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(119, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(212, 146);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(450, 600);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(900, 600);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 600);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxbNombre;
        private Label label1;
        private Label label2;
        private TextBox TbxContraseña;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Button BtnLogin;
        private Button BtnSalir;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label5;
    }
}
