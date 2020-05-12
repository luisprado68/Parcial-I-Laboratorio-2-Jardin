using JardinInfantes_Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmJardinInfantes
{
    public partial class FrmAltaAlumno : Form
    {
        public Alumno unAlumno;
        Responsable responsable;
        public List<Responsable> responsables;
        public FrmAltaAlumno()
        {
            InitializeComponent();
            responsables = new List<Responsable>();
            this.responsables.Add(new Responsable("Marta", "Ramirez", 2000, true, Eparentezco.Madre, "1550238312"));
        }

        //recibo un parinete creado del form de frm responable
        public FrmAltaAlumno(Responsable pariente) : this()
        {
            this.responsable = pariente;
            this.responsables.Add(this.responsable);
        }

        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            CargarComboParinetes(this.responsables);
        }

        // cargamos la lista al com
        public void CargarComboParinetes(List<Responsable> lista)
        {
            foreach(Responsable item in lista)
            {
                this.cmbParintes.Items.Add(item.ToString());
            }
        }
        //Obtenemosel  pariente del alumno elgido del combox
        public Responsable DevuelvoPariente(string responsable)
        {
            int pariente=0;

           for(int i = 0; i < this.responsables.Count; i++)
            {
                if(this.responsables[i].ToString() == responsable)
                {
                    pariente = i;
                    break;
                }
            }
            return this.responsables[pariente];
           
        }

        public bool ValidoPariente(string responsable)
        {
            bool pariente = false;

            for (int i = 0; i < this.responsables.Count; i++)
            {
                if (this.responsables[i].ToString() == responsable)
                {
                    pariente = true;
                    break;
                }
            }
            return pariente;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarLetras(this.textNombre.Text) &&
                Validaciones.ValidarLetras(this.textApellido.Text) &&
                Validaciones.ValidarEntero(this.textDni.Text, 999999999, 1) &&
                Validaciones.ValidarDouble(this.textPrecio.Text, 999999999, 1)&&
                this.ValidoPariente(this.cmbParintes.SelectedItem.ToString()))
                
            {


                unAlumno = new Alumno(this.textNombre.Text, this.textApellido.Text, int.Parse(textDni.Text), (radioFemenino.Checked), float.Parse(textPrecio.Text), this.DevuelvoPariente(this.cmbParintes.SelectedItem.ToString()));

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
