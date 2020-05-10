namespace FrmJardinInfantes
{
    partial class FrmSueldoNoDocente
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
            this.lbSueldoNoDocente = new System.Windows.Forms.Label();
            this.richSuedoNoDocente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbSueldoNoDocente
            // 
            this.lbSueldoNoDocente.AutoSize = true;
            this.lbSueldoNoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSueldoNoDocente.Location = new System.Drawing.Point(134, 20);
            this.lbSueldoNoDocente.Name = "lbSueldoNoDocente";
            this.lbSueldoNoDocente.Size = new System.Drawing.Size(143, 16);
            this.lbSueldoNoDocente.TabIndex = 3;
            this.lbSueldoNoDocente.Text = "Sueldo No Docente";
            // 
            // richSuedoNoDocente
            // 
            this.richSuedoNoDocente.Location = new System.Drawing.Point(12, 57);
            this.richSuedoNoDocente.Name = "richSuedoNoDocente";
            this.richSuedoNoDocente.Size = new System.Drawing.Size(401, 274);
            this.richSuedoNoDocente.TabIndex = 2;
            this.richSuedoNoDocente.Text = "";
            // 
            // FrmSueldoNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.lbSueldoNoDocente);
            this.Controls.Add(this.richSuedoNoDocente);
            this.Name = "FrmSueldoNoDocente";
            this.Text = "Suldo de No Docente";
            this.Load += new System.EventHandler(this.FrmSueldoNoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSueldoNoDocente;
        private System.Windows.Forms.RichTextBox richSuedoNoDocente;
    }
}