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
    public partial class FrmAula : Form
    {
        public List<Docente> docentes;
        public List<Alumno> alumnosSinAula;
        Aula aulaAmarilla;


        public FrmAula()
        {
            InitializeComponent();
            docentes = new List<Docente>();
            alumnosSinAula = new List<Alumno>();
            
            //Docentes sin Aula
            this.docentes.Add(new Docente("Lucas", "Rodriguez", 100, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Ezquiel", "Oggins", 101, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Martina", "Lopez", 102, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Florencia", "Cristeche", 103, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.CargarDocentes();

            // alumnos sin aula
            this.alumnosSinAula.Add(new Alumno("Luis", "Prado", 1000, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Maria", "Prado", 1002, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Laura", "Prado", 1003, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Mateo", "Stigliano", 1004, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Mauricio", "Garcia", 1005, false, 25000));

            //aula hardcoedeadeas
            aulaAmarilla = new Aula(Ecolor.Amarillo, Eturno.Mañana, docentes[0]);

           

        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            
            
            this.CargarAlumnosSinAula();

            

            AgregarDocentesAula(aulaAmarilla);
        }

        public void CargarDocentes()
        {
            listProfesoresDisponibles.Items.Clear();// limpiamos la lista 

            foreach (Docente item in this.docentes)
            {
                if (docentes.Count != 0)
                {
                    listProfesoresDisponibles.Items.Add(item.ToString());
                }

            }
        }

        public void CargarAlumnosSinAula()
        {
            listAlumnosSinAula.Items.Clear();// limpiamos la lista 

            foreach (Alumno item in this.alumnosSinAula)
            {
                if (docentes.Count != 0)
                {
                    listAlumnosSinAula.Items.Add(item.ToString());
                }

            }
        }

        public bool AgregarAlumnoAula(List<Alumno> alumnos,Aula aula,int minimo,int maximo)
        {
            bool agrego = false;
            //para aregarlos al aula cuando se crean los alumnos
            for (int i=minimo;i<maximo;i++)
            {
                    
                    
                        if(aula + alumnos[i])
                        {
                        agrego = true;
                      
                        }

            }
            return agrego;
        }

        public void AgregarAulaList(Aula aula)
        {
            foreach (Alumno item in aula.Alumnos)
            {
                if (aula.Alumnos.Count != 0)
                {
                    listAlumnosSala.Items.Add(item.ToString());
                }

            }
        }


        public void AgregarDocentesAula(Aula a)
        {
            //agergar el docente de aula
            this.cmbProfesor.Items.Clear();
            this.cmbProfesor.Items.Add(a.Docente.ToString());
                
        }

       



        //boton actualizar
        private void button1_Click(object sender, EventArgs e)
        {
            // dependiedo del color cambia el form.
            if(this.cmbColor.SelectedIndex == (int)Ecolor.Naranja)
            {
                this.BackColor = Color.Orange;
            }
            else if (this.cmbColor.SelectedIndex == (int)Ecolor.Rojo)
            {
                this.BackColor = Color.Red;
            }
            else if (this.cmbColor.SelectedIndex == (int)Ecolor.Amarillo)
            {    // depediendo de colo profesoy y turno muestra:
                this.BackColor = Color.Yellow;

                if (this.AgregarAlumnoAula(this.alumnosSinAula, aulaAmarilla, 0, 3))
                {
                    //if (cmbProfesor.Text == aulaAmarilla.Docente.ToString())
                    ////{
                        AgregarAulaList(aulaAmarilla);
                    //}

                    MessageBox.Show(this.cmbProfesor.SelectedItem.ToString()   );

                }

            }
            else if (this.cmbColor.SelectedIndex == (int)Ecolor.Verde)
            {
                this.BackColor = Color.Green;
            }

           

           



        }

        public void MostrarListaDocentes()
        {
            Console.WriteLine();
        }

        private void listProfesoresDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
