using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JardinInfantes_Biblioteca;

namespace FrmJardinInfantes
{
    public partial class FrmPrincipal : Form
    {
        FrmAltaDocente frmDocente;
        FrmAltaAlumno frmAlumno;
        FrmAula frmAula;

        List<Docente> docentes;

        public FrmPrincipal()
        {
            InitializeComponent();
            docentes = new List<Docente>();

           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        public bool AgregarDocente(Docente docente)
        {
            bool esIgual=false;
            foreach (Docente item in this.docentes)
            {
                if(item.Dni == docente.Dni)
                {
                    esIgual = true;
                }
            }

            if (!esIgual)
            {
                docentes.Add(docente);
                return true;
            }

            return false;
        }

       


        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocente = new FrmAltaDocente();
            frmDocente.ShowDialog();

            

            if (frmDocente.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("El Cliente fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
               //agrego el docente pasado por objeto formulario docente
                AgregarDocente(frmDocente.docente);
            }




        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno = new FrmAltaAlumno();
            frmAlumno.ShowDialog();
        }

        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAula = new FrmAula();
            frmAula.ShowDialog();
        }

       
    }
}
