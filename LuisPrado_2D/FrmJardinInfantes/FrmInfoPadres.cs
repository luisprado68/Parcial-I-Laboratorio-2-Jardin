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
    public partial class FrmInfoPadres : Form
    {
        FrmAula frmAula;
        public FrmInfoPadres()
        {
            InitializeComponent();
        }

        private void FrmInfoPadres_Load(object sender, EventArgs e)
        {
            frmAula = new FrmAula();
            CargarPadres(frmAula.aulas);
           
        }

        public void CargarPadres(List<Aula> aulas)
        {

            foreach (Aula aula in aulas)
            {
                this.richInfoPadres.SelectedText = "Color de Sala:"+aula.ColorSala.ToString()+"Turno: "+aula.Turno.ToString()+"\n\n";
                foreach (Alumno alumno in aula.Alumnos)
                {
                    Responsable responsable = alumno;
                    this.richInfoPadres.SelectedText =responsable.Parentezco+": " +responsable.Nombre + " " + responsable.Apellido + "" + responsable.Telefono+"\n";
                }
            }
           
        }
    }
}
