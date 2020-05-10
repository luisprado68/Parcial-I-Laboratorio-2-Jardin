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
    public partial class FrmSueldoAula : Form
    {
        FrmAula frmAula;
        public FrmSueldoAula()
        {
            InitializeComponent();
        }

        private void FrmSueldoAula_Load(object sender, EventArgs e)
        {
            frmAula = new FrmAula();

            CargarSueldoAula(frmAula.aulas);

            
        }

        public void CargarSueldoAula(List<Aula> aulas)
        {
            float recaudacion = 0;
            foreach (Aula aula in aulas)
            {
                this.richSueldoAula.SelectedText = "Color de Sala:" + aula.ColorSala.ToString() + "Turno: " + aula.Turno.ToString() + "\n";
                foreach (Alumno alumno in aula.Alumnos)
                {
                    recaudacion = 0;
                    recaudacion = alumno.PrecioCuota + recaudacion;
                    
                }
                this.richSueldoAula.SelectedText =  recaudacion + "\n";
            }

        }
    }
}
