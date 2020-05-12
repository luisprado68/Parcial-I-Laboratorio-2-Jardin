namespace FrmJardinInfantes
{
    partial class FrmAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAula));
            this.labelColor = new System.Windows.Forms.Label();
            this.labelTurno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAlumnosSala = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardarAula = new System.Windows.Forms.Button();
            this.listAlumnosSala = new System.Windows.Forms.ListBox();
            this.listAlumnosSinAula = new System.Windows.Forms.ListBox();
            this.listProfesoresDisponibles = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.agregarProfesor = new System.Windows.Forms.Button();
            this.listAulasActuales = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbAula = new System.Windows.Forms.Label();
            this.lbSala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(13, 32);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(45, 16);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "Color";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.Location = new System.Drawing.Point(9, 77);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(48, 16);
            this.labelTurno.TabIndex = 1;
            this.labelTurno.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profesor";
            // 
            // lbAlumnosSala
            // 
            this.lbAlumnosSala.AutoSize = true;
            this.lbAlumnosSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlumnosSala.Location = new System.Drawing.Point(709, 6);
            this.lbAlumnosSala.Name = "lbAlumnosSala";
            this.lbAlumnosSala.Size = new System.Drawing.Size(124, 16);
            this.lbAlumnosSala.TabIndex = 3;
            this.lbAlumnosSala.Text = "Alumnos en Sala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alumnos sin Aula";
            // 
            // cmbColor
            // 
            this.cmbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbColor.Items.AddRange(new object[] {
            "Naranja",
            "Rojo",
            "Amarillo",
            "Verde"});
            this.cmbColor.Location = new System.Drawing.Point(69, 29);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 6;
            this.cmbColor.Text = "Salas";
            // 
            // cmbTurno
            // 
            this.cmbTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cmbTurno.Location = new System.Drawing.Point(69, 73);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbTurno.TabIndex = 7;
            this.cmbTurno.Text = "Turno";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(69, 120);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesor.TabIndex = 8;
            this.cmbProfesor.Text = "Docentes";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(684, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Actualizar - Ver Aula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarAula
            // 
            this.btnGuardarAula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAula.Location = new System.Drawing.Point(684, 327);
            this.btnGuardarAula.Name = "btnGuardarAula";
            this.btnGuardarAula.Size = new System.Drawing.Size(252, 41);
            this.btnGuardarAula.TabIndex = 11;
            this.btnGuardarAula.Text = "Guardar";
            this.btnGuardarAula.UseVisualStyleBackColor = true;
            this.btnGuardarAula.Click += new System.EventHandler(this.btnGuardarAula_Click);
            // 
            // listAlumnosSala
            // 
            this.listAlumnosSala.AllowDrop = true;
            this.listAlumnosSala.FormattingEnabled = true;
            this.listAlumnosSala.Location = new System.Drawing.Point(673, 29);
            this.listAlumnosSala.Name = "listAlumnosSala";
            this.listAlumnosSala.Size = new System.Drawing.Size(252, 173);
            this.listAlumnosSala.TabIndex = 13;
            // 
            // listAlumnosSinAula
            // 
            this.listAlumnosSinAula.AllowDrop = true;
            this.listAlumnosSinAula.FormattingEnabled = true;
            this.listAlumnosSinAula.Location = new System.Drawing.Point(321, 253);
            this.listAlumnosSinAula.Name = "listAlumnosSinAula";
            this.listAlumnosSinAula.Size = new System.Drawing.Size(341, 186);
            this.listAlumnosSinAula.TabIndex = 14;
            // 
            // listProfesoresDisponibles
            // 
            this.listProfesoresDisponibles.FormattingEnabled = true;
            this.listProfesoresDisponibles.Location = new System.Drawing.Point(12, 253);
            this.listProfesoresDisponibles.Name = "listProfesoresDisponibles";
            this.listProfesoresDisponibles.Size = new System.Drawing.Size(287, 186);
            this.listProfesoresDisponibles.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Profesores Diponibles";
            // 
            // agregarProfesor
            // 
            this.agregarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarProfesor.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProfesor.Location = new System.Drawing.Point(12, 169);
            this.agregarProfesor.Name = "agregarProfesor";
            this.agregarProfesor.Size = new System.Drawing.Size(178, 34);
            this.agregarProfesor.TabIndex = 21;
            this.agregarProfesor.Text = "Crear Aula";
            this.agregarProfesor.UseVisualStyleBackColor = true;
            this.agregarProfesor.Click += new System.EventHandler(this.agregarProfesor_Click);
            // 
            // listAulasActuales
            // 
            this.listAulasActuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAulasActuales.FormattingEnabled = true;
            this.listAulasActuales.ItemHeight = 16;
            this.listAulasActuales.Location = new System.Drawing.Point(207, 30);
            this.listAulasActuales.Name = "listAulasActuales";
            this.listAulasActuales.Size = new System.Drawing.Size(391, 164);
            this.listAulasActuales.TabIndex = 22;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(684, 398);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(252, 41);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbAula
            // 
            this.lbAula.AutoSize = true;
            this.lbAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAula.Location = new System.Drawing.Point(373, 9);
            this.lbAula.Name = "lbAula";
            this.lbAula.Size = new System.Drawing.Size(111, 16);
            this.lbAula.TabIndex = 23;
            this.lbAula.Text = "Aulas Actuales";
            // 
            // lbSala
            // 
            this.lbSala.AutoSize = true;
            this.lbSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSala.Location = new System.Drawing.Point(-4, 125);
            this.lbSala.Name = "lbSala";
            this.lbSala.Size = new System.Drawing.Size(62, 16);
            this.lbSala.TabIndex = 24;
            this.lbSala.Text = "En Sala";
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 451);
            this.Controls.Add(this.lbSala);
            this.Controls.Add(this.lbAula);
            this.Controls.Add(this.listAulasActuales);
            this.Controls.Add(this.agregarProfesor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listProfesoresDisponibles);
            this.Controls.Add(this.listAlumnosSinAula);
            this.Controls.Add(this.listAlumnosSala);
            this.Controls.Add(this.btnGuardarAula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbAlumnosSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.labelColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Aula";
            this.Load += new System.EventHandler(this.FrmAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAlumnosSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardarAula;
        private System.Windows.Forms.ListBox listAlumnosSala;
        private System.Windows.Forms.ListBox listAlumnosSinAula;
        private System.Windows.Forms.ListBox listProfesoresDisponibles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button agregarProfesor;
        private System.Windows.Forms.ListBox listAulasActuales;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbAula;
        private System.Windows.Forms.Label lbSala;
    }
}