namespace FrmJardinInfantes
{
    partial class FrmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngreso));
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lPass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(44, 66);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(26, 120);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(61, 13);
            this.lPass.TabIndex = 1;
            this.lPass.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(114, 59);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(148, 20);
            this.textUsuario.TabIndex = 3;
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(114, 113);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.PasswordChar = '*';
            this.textContrasena.Size = new System.Drawing.Size(148, 20);
            this.textContrasena.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrmJardinInfantes.Properties.Resources.candado_cole;
            this.pictureBox1.Location = new System.Drawing.Point(160, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.lbUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}