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
            if (nuevoRespon)
            {
                frmAlumno = new FrmAltaAlumno(frmResponsable.responsable);
               
            }
            else
            {
                frmAlumno = new FrmAltaAlumno();
            }
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


        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void informaciónPadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoPadres = new FrmInfoPadres();
            infoPadres.ShowDialog();
            

            if (infoPadres.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);



            }
        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoDocente = new FrmSueldoDocente();
            frmSueldoDocente.ShowDialog();


            if (frmSueldoDocente.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);



            }
        }


        
        private void recaudaciónPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoAula = new FrmSueldoAula();

            frmSueldoAula.Show();
            if (frmSueldoAula.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);



            }
        }

        private void recaudaciónTotalDeJardinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecaudacionJardin = new FrmRecaudacionJardin ();

            frmRecaudacionJardin.Show();
            if (frmRecaudacionJardin.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);



            }
        }

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResponsable = new FrmResponsable();
            frmResponsable.ShowDialog();
            nuevoRespon = true;

            if (frmResponsable.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("El Pariente fue agregado satisfactoriamente",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);



            }
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrativo = new FrmAdministrativo();
            nuevoAdmin = true;
            frmAdministrativo.ShowDialog();


            if (frmAdministrativo.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Personal no docente agregado con exito",
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
            if (frmSueldoNoDocente.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("",
                                             "Confirmacion",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);



            }
        }
    }
}
