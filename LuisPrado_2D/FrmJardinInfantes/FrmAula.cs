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
        public Docente unDocente;
        public Alumno unAlumno;
        public List<Docente> docentes;
        public List<Alumno> alumnosSinAula;
        public List<Aula> aulas;
        public bool agrego = false;

       
        
        

        public FrmAula()
        {
            InitializeComponent();
            docentes = new List<Docente>();
            alumnosSinAula = new List<Alumno>();
            aulas = new List<Aula>();

           

            //Docentes sin Aula
            this.docentes.Add(new Docente("Lucas", "Rodriguez", 100, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Ezquiel", "Oggins", 101, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Martina", "Lopez", 102, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Cristian", "Baus", 103, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Ayelen", "Tobias", 104, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Marcela", "Castillo", 105, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Delfina", "Cohen", 106, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Octavio", "Vallegas", 107, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            




            // alumnos sin aula
            this.ListaAlumnos();

            //aula hardcoedeadeas
            this.aulas.Add(new Aula(Ecolor.Amarillo, Eturno.Mañana, docentes[0]));
            this.aulas.Add(new Aula(Ecolor.Amarillo, Eturno.Tarde, docentes[1]));
            this.aulas.Add(new Aula(Ecolor.Naranja, Eturno.Mañana, docentes[2]));
            this.aulas.Add(new Aula(Ecolor.Naranja, Eturno.Tarde, docentes[3]));
            this.aulas.Add(new Aula(Ecolor.Verde, Eturno.Mañana, docentes[4]));
            this.aulas.Add(new Aula(Ecolor.Verde, Eturno.Tarde, docentes[5]));
            this.aulas.Add(new Aula(Ecolor.Rojo, Eturno.Mañana, docentes[6]));
            this.aulas.Add(new Aula(Ecolor.Rojo, Eturno.Tarde, docentes[7]));

            // argego docente creado en form docente
           

           

        }

        public FrmAula(Docente docente):this()
        {
            this.unDocente = docente;
            this.AgregarDocenteLista(this.docentes, this.unDocente);

        }

        public FrmAula(Alumno alumno):this()
        {
            this.unAlumno = alumno;
            this.AgregarAlumnoLista(this.alumnosSinAula, this.unAlumno);
        }

        public FrmAula(Docente docente,Alumno alumno) : this()
        {
            this.unDocente = docente;
            this.unAlumno = alumno;
            this.AgregarDocenteLista(this.docentes, this.unDocente);
            this.AgregarAlumnoLista(this.alumnosSinAula, this.unAlumno);

        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            
            

            this.CargarAlumnosSinAula();
            AgregarDocentesAula(this.aulas);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[0], 0, 2);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[1], 3, 5);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[2], 6, 8);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[3], 9, 11);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[4], 12, 14);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[5], 15, 17);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[6], 18, 20);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[7], 21, 23);

            
            this.CargarDocentes();
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

        public bool AgregarDocenteLista(List<Docente> l,Docente d)
        {
            bool esigual = false;

           for(int i = 0; i < l.Count; i++)
            {
                if (d.Dni == l[i].Dni)
                {
                    esigual = true;
                }
            }

            if (!esigual)
            {
                l.Add(d);
            }


            return esigual;
        }

        public bool AgregarAlumnoLista(List<Alumno> lista,Alumno a)
        {
            bool esIgual = false;

            foreach (var item in lista)
            {
                if(item.Dni == a.Dni)
                {
                    esIgual = true;
                }
            }

            if (!esIgual)
            {
                lista.Add(a);
            }
            return esIgual;
        }

        public void AgregarDocentesAula(List<Aula> a)
        {
            //agergar el docente de aula


            this.cmbProfesor.Items.Clear();

            foreach (Aula item in a)
            {
                this.cmbProfesor.Items.Add(item.Docente.ToString());
            }
            
                
        }

       



        //boton actualizar
        private void button1_Click(object sender, EventArgs e)
        {

            
            // dependiedo del color cambia el form.
            if (this.cmbColor.SelectedIndex + 1 == (int)Ecolor.Naranja)
            {
                this.BackColor = Color.Orange;

                if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[2].Docente.ToString() && this.cmbTurno.SelectedItem.ToString() == this.aulas[2].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();
                    AgregarAulaList(this.aulas[2]);

                }
                else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[3].Docente.ToString() && this.cmbTurno.SelectedItem.ToString() == this.aulas[3].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();

                    AgregarAulaList(this.aulas[3]);
                }
                else
                {
                    MessageBox.Show("No existe un aula con esos parametros!");
                }
            }
            else if (this.cmbColor.SelectedIndex + 1== (int)Ecolor.Rojo)
            {
                this.BackColor = Color.Red;

                if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[6].Docente.ToString() && this.cmbTurno.SelectedItem.ToString() == this.aulas[6].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();
                    AgregarAulaList(this.aulas[6]);

                }
                else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[7].Docente.ToString() && this.cmbTurno.SelectedItem.ToString() == this.aulas[7].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();

                    AgregarAulaList(this.aulas[7]);
                }
                else
                {
                    MessageBox.Show("No existe un aula con esos parametros!");
                }
            }
            else if (this.cmbColor.SelectedIndex + 1 == (int)Ecolor.Amarillo)
            {    // depediendo de colo profesoy y turno muestra:
                
                   this.BackColor = Color.Yellow;

                    if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[0].Docente.ToString() && this.cmbTurno.SelectedItem.ToString()== this.aulas[0].Turno.ToString())
                    {
                        this.listAlumnosSala.Items.Clear();
                        AgregarAulaList(this.aulas[0]);
                        
                    }else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[1].Docente.ToString() && this.cmbTurno.SelectedItem.ToString() == this.aulas[1].Turno.ToString())
                    {
                        this.listAlumnosSala.Items.Clear();

                        AgregarAulaList(this.aulas[1]);
                    }
                    else
                    {
                        MessageBox.Show("No existe un aula con esos parametros!");
                    }

            }
            else if (this.cmbColor.SelectedIndex+1 == (int)Ecolor.Verde)
            {
                this.BackColor = Color.Green;

                if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[4].Docente.ToString() && this.cmbTurno.SelectedItem.ToString() == this.aulas[4].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();
                    AgregarAulaList(this.aulas[4]);

                }
                else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[5].Docente.ToString() && this.cmbTurno.SelectedItem.ToString() == this.aulas[5].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();

                    AgregarAulaList(this.aulas[5]);
                }
                else
                {
                    MessageBox.Show("No existe un aula con esos parametros!");
                }
            }

           

           



        }

        public void MostrarListaDocentes()
        {
            Console.WriteLine();
        }

        private void listProfesoresDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ListaAlumnos()
        {
            this.alumnosSinAula.Add(new Alumno("Luis", "Prado", 1000, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Maria", "Prado", 1002, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Laura", "Prado", 1003, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Mateo", "Stigliano", 1004, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Valentina", "Lopez", 1005, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Martin", "Garcia", 1006, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Graciela", "Garcia", 1007, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Jazmin", "Chavez", 1008, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Matias", "Chavez", 1009, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Nicolas", "Miloro", 1010, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Lucia", "Finochi", 1011, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Leticia", "Garcia", 1012, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Julieta", "Maas", 1013, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Nicole", "Ferreyra", 1014, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Luna", "Herrera", 1015, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Kael", "Alessandroni", 1016, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Martin", "Prado", 1017, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Mauro", "Lara", 1018, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Ezequiel", "Montero", 1019, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Florencia", "Gonzales", 1020, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Marcela", "Gimenez", 1021, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Gonzalo", "Montenegro", 1022, false, 25000));
            this.alumnosSinAula.Add(new Alumno("Etelvina", "Cleres", 1023, true, 25000));
            this.alumnosSinAula.Add(new Alumno("Daniel", "Gorostiaga", 1024, false, 25000));
            
        }
    }
}
