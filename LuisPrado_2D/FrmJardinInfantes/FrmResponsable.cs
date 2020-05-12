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
    public partial class FrmResponsable : Form
    {
        Responsable responsable;
        
        public FrmResponsable()
        {
            InitializeComponent();
            
        }

        public Responsable Reponsable
        {
            get { return this.responsable; }

        }

        private void FrmResponsable_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarLetras(this.textNombre.Text) &&
                Validaciones.ValidarLetras(this.textApellido.Text) &&
                Validaciones.ValidarEntero(this.textDni.Text, 999999999, 1) &&
                Validaciones.ValidarParentezco(this.cmbParentezco.SelectedItem.ToString()) &&
                Validaciones.ValidarEntero(this.textTelefono.Text, 999999999, 1))

            {

                responsable = new Responsable(this.textNombre.Text, this.textApellido.Text, int.Parse(textDni.Text), (radioFemenino.Checked), Validaciones.RetornoParentezco(cmbParentezco.SelectedItem.ToString()), this.textTelefono.Text);

                    this.DialogResult = DialogResult.OK;
                
            }
            else
             {
                MessageBox.Show("Algunos de los datos estan incorrectos!");
                Limpiar(this);

            }

        }
            /// <summary>
            /// Agrega un responsable a la lista antes valida si agrega es falso y si no verdadero
            /// </summary>
            /// <param name="responsable"></param>
            /// <returns></returns>
            

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    } 
}
