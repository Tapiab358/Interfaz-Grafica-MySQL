namespace Interfaz_MySQL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConectar = new Button();
            dgvDatos = new DataGridView();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtHost = new TextBox();
            txtBD = new TextBox();
            txtPuerto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.BackColor = SystemColors.GrayText;
            btnConectar.BackgroundImage = (Image)resources.GetObject("btnConectar.BackgroundImage");
            btnConectar.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConectar.ForeColor = SystemColors.ActiveCaptionText;
            btnConectar.Location = new Point(411, 102);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(177, 56);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click_1;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = SystemColors.Highlight;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.GridColor = SystemColors.MenuBar;
            dgvDatos.Location = new Point(12, 276);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(996, 214);
            dgvDatos.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(182, 18);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(191, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(182, 68);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(191, 27);
            txtContrasena.TabIndex = 3;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(182, 120);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(191, 27);
            txtHost.TabIndex = 4;
            // 
            // txtBD
            // 
            txtBD.Location = new Point(182, 169);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(191, 27);
            txtBD.TabIndex = 5;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(182, 214);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(191, 27);
            txtPuerto.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(41, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 7;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(41, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 8;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(41, 120);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 9;
            label3.Text = "Host:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(41, 169);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 10;
            label4.Text = "Base de Datos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(41, 214);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 11;
            label5.Text = "Puerto:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(711, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 218);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1020, 502);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPuerto);
            Controls.Add(txtBD);
            Controls.Add(txtHost);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(dgvDatos);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Interfaz MySQL";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private DataGridView dgvDatos;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtHost;
        private TextBox txtBD;
        private TextBox txtPuerto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
