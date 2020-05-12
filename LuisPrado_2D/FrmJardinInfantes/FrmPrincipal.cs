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
        FrmResponsable frmResponsable;
        FrmAltaDocente frmDocente;
        FrmAltaAlumno frmAlumno;
        FrmAula frmAula;
        FrmAdministrativo frmAdministrativo;
        

        FrmInfoPadres infoPadres;
        FrmSueldoDocente frmSueldoDocente;
        FrmSueldoNoDocente frmSueldoNoDocente;
        FrmSueldoAula frmSueldoAula;
        FrmRecaudacionJardin frmRecaudacionJardin;
        public bool nuevoDocente;
        public bool nuevoAlumno;
        public bool nuevoRespon;
        public bool nuevoAdmin;

        public FrmPrincipal()
        {
            InitializeComponent();
           
            nuevoDocente = false;
            nuevoAlumno = false;
            nuevoAdmin = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {   
            
        }

        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocente = new FrmAltaDocente();
            frmDocente.ShowDialog();
            


            if (frmDocente.DialogResult == DialogResult.OK)
            {
                nuevoDocente = true;//cuando creo un docente
                MessageBox.Show("El Docente fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
                //agrego el docente pasado por objeto formulario docente
               
               
            }
            else
            {
                MessageBox.Show("No se agrego ningun Docente",
                                            "Confirmacion",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
            }

        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nuevoRespon)
            {
                frmAlumno = new FrmAltaAlumno(frmResponsable.Reponsable);
               
            }
            else
            {
                frmAlumno = new FrmAltaAlumno();
            }

            frmAlumno.ShowDialog();
            

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                nuevoAlumno = true;// cuando cree el alumno
                MessageBox.Show("El Alumno fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se agrego ningun Alumno",
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

            }
            else if (nuevoDocente && nuevoAlumno )
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


        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void informaciónPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoPadres = new FrmInfoPadres();
            infoPadres.ShowDialog();
            
        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoDocente = new FrmSueldoDocente();
            frmSueldoDocente.ShowDialog();

        }


        
        private void recaudaciónPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoAula = new FrmSueldoAula();

            frmSueldoAula.Show();
           
        }

        private void recaudaciónTotalDeJardinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecaudacionJardin = new FrmRecaudacionJardin ();

            frmRecaudacionJardin.Show();
            
        }

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResponsable = new FrmResponsable();
            frmResponsable.ShowDialog();
            

            if (frmResponsable.DialogResult == DialogResult.OK)
            {
                nuevoRespon = true;// cuando se crea es verdadero
                MessageBox.Show("El Pariente fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);

            }
            else
            {
                
                MessageBox.Show("No se agrego ningun pariente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrativo = new FrmAdministrativo();
            frmAdministrativo.ShowDialog();


            if (frmAdministrativo.DialogResult == DialogResult.OK)
            {
                nuevoAdmin = true;
                MessageBox.Show("Personal no docente agregado con exito",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se agrego Personal No Docente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
        }

        

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nuevoAdmin)
            {
                frmSueldoNoDocente = new FrmSueldoNoDocente(this.frmAdministrativo.Admin);
    
            }
            else
            {
                frmSueldoNoDocente = new FrmSueldoNoDocente();
            }
                frmSueldoNoDocente.ShowDialog();
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
