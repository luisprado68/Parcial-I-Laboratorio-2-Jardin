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
    public partial class FrmRecaudacionJardin : Form
    {
        FrmAula frmAula;
        public FrmRecaudacionJardin()
        {
            InitializeComponent();
        }

        private void FrmRecaudacionJardin_Load(object sender, EventArgs e)
        {
            frmAula = new FrmAula();
            CargarRecaudacionJardin(frmAula.aulas);
        }

        public void CargarRecaudacionJardin(List<Aula> aulas)
        {
            float recaudacionAula = 0;
            float recaudacionJardin = 0;
            this.richRecaudacion.SelectedText = "Recaudacion Total de Jardin" + "\n";
            foreach (Aula aula in aulas)
            {
                
                foreach (Alumno alumno in aula.Alumnos)
                {
                    
                    recaudacionAula = alumno.PrecioCuota + recaudacionAula;

                }
                recaudacionJardin = recaudacionAula + recaudacionJardin;
                recaudacionAula = 0;
            }

            this.richRecaudacion.SelectedText = recaudacionJardin + "\n";
            
        }
    }
}
