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
        public int horaEntrada;
        public int horaSalida;


        public FrmAltaDocente()
        {
            InitializeComponent();
        }

        private void FrmAltaDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int horaEntrada=0;
            int horaSalida=0;

            if (Validaciones.ValidarLetras(this.textNombre.Text) &&
                Validaciones.ValidarLetras(this.textApellido.Text) &&
                Validaciones.ValidarEntero(this.textDni.Text, 999999999, 1) &&
                Validaciones.ValidarEntero(this.textHoraEntrada.Text, 23,0) &&
                Validaciones.ValidarEntero(this.textHoraSalida.Text, 23,0) &&
                Validaciones.ValidarEntero(this.textValorHora.Text, 999999999,1))
            {
                horaEntrada = int.Parse(textHoraEntrada.Text);
                horaSalida = int.Parse(textHoraSalida.Text);
                docente = new Docente(this.textNombre.Text, this.textApellido.Text, int.Parse(textDni.Text), (radioFemenino.Checked), DateTime.Parse(horaEntrada+":00"), DateTime.Parse(horaSalida+":00"), double.Parse(textValorHora.Text));

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Algunos de los datos estan incorrectos!");
                Limpiar(this);
               
            }

                

               
        }

        public static void Limpiar(Form formu)
        {
            // Recorrer todos los controles del formulario
            foreach (Control controles in formu.Controls)
            {
                if (controles is TextBox)
                {
                    controles.Text = "";
                    // Eliminar el texto del TextBox
                }
                
                if (controles is ComboBox)
                {
                    controles.Text = "";
                    // Eliminar el texto del Combobox
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
