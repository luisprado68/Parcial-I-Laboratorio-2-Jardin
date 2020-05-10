namespace FrmJardinInfantes
{
    partial class FrmInfoPadres
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
            this.richInfoPadres = new System.Windows.Forms.RichTextBox();
            this.lbInfoPadres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richInfoPadres
            // 
            this.richInfoPadres.Location = new System.Drawing.Point(24, 46);
            this.richInfoPadres.Name = "richInfoPadres";
            this.richInfoPadres.Size = new System.Drawing.Size(401, 274);
            this.richInfoPadres.TabIndex = 0;
            this.richInfoPadres.Text = "";
            // 
            // lbInfoPadres
            // 
            this.lbInfoPadres.AutoSize = true;
            this.lbInfoPadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoPadres.Location = new System.Drawing.Point(117, 9);
            this.lbInfoPadres.Name = "lbInfoPadres";
            this.lbInfoPadres.Size = new System.Drawing.Size(197, 16);
            this.lbInfoPadres.TabIndex = 1;
            this.lbInfoPadres.Text = "Informacion de Los Padres:";
            // 
            // FrmInfoPadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.lbInfoPadres);
            this.Controls.Add(this.richInfoPadres);
            this.Name = "FrmInfoPadres";
            this.Text = "FrmInfoPadres";
            this.Load += new System.EventHandler(this.FrmInfoPadres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richInfoPadres;
        private System.Windows.Forms.Label lbInfoPadres;
    }
}