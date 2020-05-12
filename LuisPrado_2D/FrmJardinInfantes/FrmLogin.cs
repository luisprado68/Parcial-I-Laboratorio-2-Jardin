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
    public partial class FrmLogin : Form
    {
        Administrativo usuario;
        private string user;
        private string pass;
        public FrmLogin()
        {
            InitializeComponent();
            usuario = new Administrativo("Luis", "Prado", 39207770, false, new DateTime(1, 1, 1, 1, 1, 1), new DateTime(1, 1, 1, 1, 1, 1), ECargo.Secretaría);
            user = "admin";
            pass = "admin";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == user && textPass.Text == pass)
            {
                //pictureBox1.Show();
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
