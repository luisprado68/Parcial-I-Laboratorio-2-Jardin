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
    public partial class FrmIngreso : Form
    {
        Administrativo usuario;
        private string user;
        private string pass;
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            usuario = new Administrativo("Luis", "Prado", 39207770, false, new DateTime(1, 1, 1, 1, 1, 1), new DateTime(1, 1, 1, 1, 1, 1), ECargo.Secretaría);
            user = "admin";
            pass = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == user && textContrasena.Text == pass)
            {
                
                MessageBox.Show("Bienvenido " + usuario.Nombre);
                this.Hide();

                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos ");
            }
        }
    }
}
