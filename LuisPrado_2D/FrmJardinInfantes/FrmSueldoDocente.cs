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
    public partial class FrmSueldoDocente : Form
    {
        FrmAula frmAula;
        public FrmSueldoDocente()
        {
            InitializeComponent();
            frmAula = new FrmAula();
        }

        private void FrmSueldoDocente_Load(object sender, EventArgs e)
        {
            cargarSueldoDocente(frmAula.docentes);
        }

        public void cargarSueldoDocente(List<Docente> docentes)
        {

            foreach (Docente docente in docentes)
            {
                this.richSueldoDocente.SelectedText = "Profesor:" + docente.Nombre+" "+docente.Salario+ "\n";
                
            }

        }

    }
}
