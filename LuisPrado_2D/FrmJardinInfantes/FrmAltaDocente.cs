using JardinInfantes_Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmJardinInfantes
{
    public partial class FrmAltaDocente : Form
    {
        public Docente docente;
        public FrmAltaDocente()
        {
            InitializeComponent();
        }

        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            docente = new Docente(this.textNombre.Text, this.textApellido.Text, int.Parse(textDni.Text), bool.Parse(textSexo.Text), DateTime.Parse( textHoraEntrada.Text), DateTime.Parse(textHoraSalida.Text),double.Parse(textValorHora.Text));
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
