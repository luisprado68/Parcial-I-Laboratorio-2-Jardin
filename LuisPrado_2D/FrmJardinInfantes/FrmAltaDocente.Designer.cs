namespace FrmJardinInfantes
{
    partial class FrmAltaDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaDocente));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textValorHora = new System.Windows.Forms.TextBox();
            this.textHoraSalida = new System.Windows.Forms.TextBox();
            this.textHoraEntrada = new System.Windows.Forms.TextBox();
            this.radioFemenino = new System.Windows.Forms.RadioButton();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(43, 295);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(213, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hora de Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hora de Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Valor por Hora";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(175, 16);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(132, 20);
            this.textNombre.TabIndex = 9;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(175, 54);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(132, 20);
            this.textApellido.TabIndex = 10;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(175, 90);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(132, 20);
            this.textDni.TabIndex = 11;
            // 
            // textValorHora
            // 
            this.textValorHora.Location = new System.Drawing.Point(175, 234);
            this.textValorHora.Name = "textValorHora";
            this.textValorHora.Size = new System.Drawing.Size(132, 20);
            this.textValorHora.TabIndex = 15;
            // 
            // textHoraSalida
            // 
            this.textHoraSalida.Location = new System.Drawing.Point(175, 198);
            this.textHoraSalida.Name = "textHoraSalida";
            this.textHoraSalida.Size = new System.Drawing.Size(132, 20);
            this.textHoraSalida.TabIndex = 14;
            // 
            // textHoraEntrada
            // 
            this.textHoraEntrada.Location = new System.Drawing.Point(175, 160);
            this.textHoraEntrada.Name = "textHoraEntrada";
            this.textHoraEntrada.Size = new System.Drawing.Size(132, 20);
            this.textHoraEntrada.TabIndex = 13;
            // 
            // radioFemenino
            // 
            this.radioFemenino.AutoSize = true;
            this.radioFemenino.Checked = true;
            this.radioFemenino.Location = new System.Drawing.Point(22, 19);
            this.radioFemenino.Name = "radioFemenino";
            this.radioFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioFemenino.TabIndex = 16;
            this.radioFemenino.TabStop = true;
            this.radioFemenino.Text = "Femenino";
            this.radioFemenino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(111, 19);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioMasculino.TabIndex = 17;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMasculino);
            this.groupBox1.Controls.Add(this.radioFemenino);
            this.groupBox1.Location = new System.Drawing.Point(138, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 38);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // FrmAltaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textValorHora);
            this.Controls.Add(this.textHoraSalida);
            this.Controls.Add(this.textHoraEntrada);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAltaDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Docente";
            this.Load += new System.EventHandler(this.FrmAltaDocente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textValorHora;
        private System.Windows.Forms.TextBox textHoraSalida;
        private System.Windows.Forms.TextBox textHoraEntrada;
        private System.Windows.Forms.RadioButton radioFemenino;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}