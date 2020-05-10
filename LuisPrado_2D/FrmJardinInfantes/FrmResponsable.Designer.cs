namespace FrmJardinInfantes
{
    partial class FrmResponsable
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
            this.grupoSexo = new System.Windows.Forms.GroupBox();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFemenino = new System.Windows.Forms.RadioButton();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lbParentezco = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.cmbParentezco = new System.Windows.Forms.ComboBox();
            this.grupoSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoSexo
            // 
            this.grupoSexo.Controls.Add(this.radioMasculino);
            this.grupoSexo.Controls.Add(this.radioFemenino);
            this.grupoSexo.Location = new System.Drawing.Point(118, 144);
            this.grupoSexo.Name = "grupoSexo";
            this.grupoSexo.Size = new System.Drawing.Size(216, 38);
            this.grupoSexo.TabIndex = 44;
            this.grupoSexo.TabStop = false;
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
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(172, 118);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(132, 20);
            this.textDni.TabIndex = 42;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(172, 82);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(132, 20);
            this.textApellido.TabIndex = 41;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(172, 44);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(132, 20);
            this.textNombre.TabIndex = 40;
            // 
            // lbParentezco
            // 
            this.lbParentezco.AutoSize = true;
            this.lbParentezco.Location = new System.Drawing.Point(37, 195);
            this.lbParentezco.Name = "lbParentezco";
            this.lbParentezco.Size = new System.Drawing.Size(61, 13);
            this.lbParentezco.TabIndex = 39;
            this.lbParentezco.Text = "Parentezco";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(42, 160);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(31, 13);
            this.lbSexo.TabIndex = 38;
            this.lbSexo.Text = "Sexo";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(42, 125);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(26, 13);
            this.lbDni.TabIndex = 37;
            this.lbDni.Text = "DNI";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(37, 89);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 36;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(37, 51);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 35;
            this.lbNombre.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(210, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(28, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(37, 235);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 45;
            this.lbTelefono.Text = "Telefono";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(172, 228);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(132, 20);
            this.textTelefono.TabIndex = 46;
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Tía",
            "Tío",
            "Abuela",
            "Abuelo",
            "Otro"});
            this.cmbParentezco.Location = new System.Drawing.Point(172, 188);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(132, 21);
            this.cmbParentezco.TabIndex = 47;
            // 
            // FrmResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 327);
            this.Controls.Add(this.cmbParentezco);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.grupoSexo);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lbParentezco);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmResponsable";
            this.Text = "Alta Rezponsable";
            this.Load += new System.EventHandler(this.FrmResponsable_Load);
            this.grupoSexo.ResumeLayout(false);
            this.grupoSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoSexo;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFemenino;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lbParentezco;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.ComboBox cmbParentezco;
    }
}