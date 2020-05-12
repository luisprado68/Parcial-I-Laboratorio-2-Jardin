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
    public partial class FrmAdministrativo : Form
    {
        Administrativo admin;
        private int horaEntrada;
        private int horaSalida;
        public Administrativo Admin
        {
            get { return this.admin; }
            set { this.admin = value; }
        }

        public FrmAdministrativo()
        {
            InitializeComponent();
        }

        private void FrmAdministrativo_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            horaEntrada = 0;
            horaSalida = 0;

            if (Validaciones.ValidarLetras(this.textNombre.Text) &&
                Validaciones.ValidarLetras(this.textApellido.Text) &&
                Validaciones.ValidarEntero(this.textDni.Text, 999999999, 1) &&
                Validaciones.ValidarEntero(this.textHoraEntrada.Text, 23, 0) &&
                Validaciones.ValidarEntero(this.textHoraSalida.Text, 23, 0) &&
                Validaciones.ValidarCargo(this.cmbCargo.SelectedItem.ToString())
                )
            {
                horaEntrada = int.Parse(textHoraEntrada.Text);
                horaSalida = int.Parse(textHoraSalida.Text);
                admin = new Administrativo(this.textNombre.Text, this.textApellido.Text, int.Parse(textDni.Text), (radioFemenino.Checked), DateTime.Parse(horaEntrada + ":00"), DateTime.Parse(horaSalida + ":00"), RetornarCargo(cmbCargo.SelectedItem.ToString()));

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Algunos de los datos estan incorrectos!");
                Limpiar(this);

            }



        }

        public ECargo RetornarCargo(string cargo)
        {
            if(cargo == ECargo.Cocina.ToString())
            {
                return ECargo.Cocina;
            }
            else if(cargo == ECargo.Dirección.ToString())
            {
                return ECargo.Dirección;
            }
            else if (cargo == ECargo.Portería.ToString())
            {
                return ECargo.Portería;
            }
            else if (cargo == ECargo.Secretaría.ToString())
            {
                return ECargo.Secretaría;
            }
            else
            {
                return ECargo.Tesorería;
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
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }
    }
}
