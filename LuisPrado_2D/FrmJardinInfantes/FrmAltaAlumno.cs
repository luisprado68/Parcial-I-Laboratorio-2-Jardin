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
    public partial class FrmAltaAlumno : Form
    {
        public Alumno unAlumno;
        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        

        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarLetras(this.textNombre.Text) &&
                Validaciones.ValidarLetras(this.textApellido.Text) &&
                Validaciones.ValidarEntero(this.textDni.Text, 999999999, 1) &&
                Validaciones.ValidarDouble(this.textPrecio.Text, 999999999, 1))
                
            {
                
                unAlumno = new Alumno(this.textNombre.Text, this.textApellido.Text, int.Parse(textDni.Text), (radioFemenino.Checked),float.Parse(textPrecio.Text));

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
                //if (controles is RadioButton)
                //{
                //    controles. = "";
                //    // Eliminar el texto del Label
                //}
                if (controles is ComboBox)
                {
                    controles.Text = "";
                    // Eliminar el texto del Combobox
                }
            }
        }

        
    }
}
