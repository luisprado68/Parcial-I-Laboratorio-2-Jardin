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
    
    public partial class FrmSueldoNoDocente : Form
    {
        FrmPrincipal frmPrincipal;
        Administrativo admin;
        List<Administrativo> administrativos;
        public FrmSueldoNoDocente()
        {
            InitializeComponent();
            administrativos = new List<Administrativo>();
        }

        public FrmSueldoNoDocente(Administrativo admin):this()
        {
            this.admin = admin;
        }
        private void FrmSueldoNoDocente_Load(object sender, EventArgs e)
        {
            frmPrincipal = new FrmPrincipal();
            AgregarAdministrativo(this.administrativos, this.admin);
            CargarSueldoNoDocente( this.administrativos);
        }

        public void CargarSueldoNoDocente(List<Administrativo> lista)
        {
            foreach (Administrativo item in lista)
            {
                this.richSuedoNoDocente.SelectedText = item.Salario.ToString();
            }
        }

        public void AgregarAdministrativo(List<Administrativo> admins, Administrativo admin)
        {
            bool esIgual = false;
            for (int i = 0; i < admins.Count; i++)
            {
                if (admin.Dni == admins[i].Dni)
                {
                    esIgual = true;
                }

            }

            if (!esIgual)
            {
                admins.Add(admin);
            }
        }
    }
}
