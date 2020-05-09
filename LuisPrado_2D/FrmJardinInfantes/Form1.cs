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
        public bool nuevoDocente;
        public bool nuevoAlumno;



        public FrmPrincipal()
        {
            InitializeComponent();
            nuevoDocente = false;
            nuevoAlumno = false;
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

       

       


        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocente = new FrmAltaDocente();
            frmDocente.ShowDialog();
            nuevoDocente = true;

            

            if (frmDocente.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("El Docente fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                //agrego el docente pasado por objeto formulario docente
               
               
            }




        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno = new FrmAltaAlumno();
            frmAlumno.ShowDialog();
            nuevoAlumno = true;

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("El Alumno fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                


            }
        }

        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //si se creo un nuevo docente lo agrega
            if (nuevoDocente==false && nuevoAlumno==true)
            {
                frmAula = new FrmAula(frmAlumno.unAlumno);


                frmAula.ShowDialog();
            }
            else if (nuevoDocente== true && nuevoAlumno == false)
            {
                frmAula = new FrmAula(frmDocente.docente);


                frmAula.ShowDialog();
            }else if (nuevoDocente && nuevoAlumno )
            {
                frmAula = new FrmAula(frmDocente.docente,frmAlumno.unAlumno);


                frmAula.ShowDialog();
            }
            else
            {
                frmAula = new FrmAula();


                frmAula.ShowDialog(); 

            }
           
        }

       
    }
}
