namespace FrmJardinInfantes
{
    partial class FrmSueldoAula
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
            this.lbSueldoAula = new System.Windows.Forms.Label();
            this.richSueldoAula = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbSueldoAula
            // 
            this.lbSueldoAula.AutoSize = true;
            this.lbSueldoAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSueldoAula.Location = new System.Drawing.Point(153, 23);
            this.lbSueldoAula.Name = "lbSueldoAula";
            this.lbSueldoAula.Size = new System.Drawing.Size(119, 16);
            this.lbSueldoAula.TabIndex = 3;
            this.lbSueldoAula.Text = "Sueldo por Aula";
            // 
            // richSueldoAula
            // 
            this.richSueldoAula.Location = new System.Drawing.Point(12, 53);
            this.richSueldoAula.Name = "richSueldoAula";
            this.richSueldoAula.Size = new System.Drawing.Size(401, 274);
            this.richSueldoAula.TabIndex = 2;
            this.richSueldoAula.Text = "";
            // 
            // FrmSueldoAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 344);
            this.Controls.Add(this.lbSueldoAula);
            this.Controls.Add(this.richSueldoAula);
            this.Name = "FrmSueldoAula";
            this.Text = "Sueldo por Aula";
            this.Load += new System.EventHandler(this.FrmSueldoAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSueldoAula;
        private System.Windows.Forms.RichTextBox richSueldoAula;
    }
}