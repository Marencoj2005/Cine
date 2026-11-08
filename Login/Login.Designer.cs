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
            TxbNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TbxContraseña = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            BtnLogin = new Button();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TxbNombre
            // 
            TxbNombre.BackColor = SystemColors.GradientInactiveCaption;
            TxbNombre.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxbNombre.Location = new Point(45, 184);
            TxbNombre.Multiline = true;
            TxbNombre.Name = "TxbNombre";
            TxbNombre.Size = new Size(325, 32);
            TxbNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 145);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 312);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // TbxContraseña
            // 
            TbxContraseña.BackColor = SystemColors.GradientInactiveCaption;
            TbxContraseña.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbxContraseña.Location = new Point(45, 342);
            TbxContraseña.Multiline = true;
            TbxContraseña.Name = "TbxContraseña";
            TbxContraseña.Size = new Size(325, 32);
            TbxContraseña.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 222);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 2);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(45, 380);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(325, 2);
            textBox4.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(18, 301);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(167, 73);
            label3.Name = "label3";
            label3.Size = new Size(70, 29);
            label3.TabIndex = 8;
            label3.Text = "Login";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.ActiveCaptionText;
            BtnLogin.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = SystemColors.ButtonFace;
            BtnLogin.Location = new Point(117, 434);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(179, 26);
            BtnLogin.TabIndex = 9;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.Location = new Point(354, 589);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 10;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(441, 624);
            Controls.Add(BtnSalir);
            Controls.Add(BtnLogin);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(TbxContraseña);
            Controls.Add(label1);
            Controls.Add(TxbNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxbNombre;
        private Label label1;
        private Label label2;
        private TextBox TbxContraseña;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Button BtnLogin;
        private Button BtnSalir;
    }
}
