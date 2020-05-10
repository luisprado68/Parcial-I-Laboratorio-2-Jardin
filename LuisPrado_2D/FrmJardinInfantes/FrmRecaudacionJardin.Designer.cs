namespace FrmJardinInfantes
{
    partial class FrmRecaudacionJardin
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
            this.lbRecaudacionJardin = new System.Windows.Forms.Label();
            this.richRecaudacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbRecaudacionJardin
            // 
            this.lbRecaudacionJardin.AutoSize = true;
            this.lbRecaudacionJardin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecaudacionJardin.Location = new System.Drawing.Point(105, 23);
            this.lbRecaudacionJardin.Name = "lbRecaudacionJardin";
            this.lbRecaudacionJardin.Size = new System.Drawing.Size(169, 16);
            this.lbRecaudacionJardin.TabIndex = 3;
            this.lbRecaudacionJardin.Text = "Recaudacion de Jardin";
            // 
            // richRecaudacion
            // 
            this.richRecaudacion.Location = new System.Drawing.Point(12, 60);
            this.richRecaudacion.Name = "richRecaudacion";
            this.richRecaudacion.Size = new System.Drawing.Size(401, 274);
            this.richRecaudacion.TabIndex = 2;
            this.richRecaudacion.Text = "";
            // 
            // FrmRecaudacionJardin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 343);
            this.Controls.Add(this.lbRecaudacionJardin);
            this.Controls.Add(this.richRecaudacion);
            this.Name = "FrmRecaudacionJardin";
            this.Text = "Recaudacion de Jardin";
            this.Load += new System.EventHandler(this.FrmRecaudacionJardin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecaudacionJardin;
        private System.Windows.Forms.RichTextBox richRecaudacion;
    }
}