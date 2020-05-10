namespace FrmJardinInfantes
{
    partial class FrmSueldoDocente
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
            this.lbSuledoDocente = new System.Windows.Forms.Label();
            this.richSueldoDocente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbSuledoDocente
            // 
            this.lbSuledoDocente.AutoSize = true;
            this.lbSuledoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuledoDocente.Location = new System.Drawing.Point(138, 9);
            this.lbSuledoDocente.Name = "lbSuledoDocente";
            this.lbSuledoDocente.Size = new System.Drawing.Size(174, 16);
            this.lbSuledoDocente.TabIndex = 3;
            this.lbSuledoDocente.Text = "Sueldo de los Docentes";
            // 
            // richSueldoDocente
            // 
            this.richSueldoDocente.Location = new System.Drawing.Point(30, 44);
            this.richSueldoDocente.Name = "richSueldoDocente";
            this.richSueldoDocente.Size = new System.Drawing.Size(401, 296);
            this.richSueldoDocente.TabIndex = 2;
            this.richSueldoDocente.Text = "";
            // 
            // FrmSueldoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 352);
            this.Controls.Add(this.lbSuledoDocente);
            this.Controls.Add(this.richSueldoDocente);
            this.Name = "FrmSueldoDocente";
            this.Text = "Sueldo Docente";
            this.Load += new System.EventHandler(this.FrmSueldoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSuledoDocente;
        private System.Windows.Forms.RichTextBox richSueldoDocente;
    }
}