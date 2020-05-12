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
        
        Administrativo admin;
        List<Administrativo> administrativos;
        public FrmSueldoNoDocente()
        {
            InitializeComponent();
            administrativos = new List<Administrativo>();
            this.administrativos.Add(new Administrativo("Omar", "Lopez", 35258451, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), ECargo.Cocina));
            this.administrativos.Add(new Administrativo("Fransisca", "Herrera", 35258452, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), ECargo.Dirección));
            this.administrativos.Add(new Administrativo("Javier", "Martinez", 35258454, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), ECargo.Portería));
            this.administrativos.Add(new Administrativo("Julieta", "Maas", 35258458, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), ECargo.Secretaría));
            this.administrativos.Add(new Administrativo("Mauricio", "Garcia", 35258412, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), ECargo.Tesorería));

        }

        public FrmSueldoNoDocente(Administrativo admin):this()
        {
            this.admin = admin;
            AgregarAdministrativo(this.administrativos, this.admin);
        }
        private void FrmSueldoNoDocente_Load(object sender, EventArgs e)
        {
           
            
            CargarSueldoNoDocente( this.administrativos);
        }

        public void CargarSueldoNoDocente(List<Administrativo> lista)
        {
            foreach (Administrativo item in lista)
            {
                this.richSuedoNoDocente.SelectedText =item.Nombre+""+item.Apellido+" "+item.Cargo+" "+item.Salario+"\n";
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
