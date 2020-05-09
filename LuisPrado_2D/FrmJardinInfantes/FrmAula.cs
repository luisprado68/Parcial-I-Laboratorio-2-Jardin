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
        public Aula aula;
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

            //Docentes sin Aula lista
            this.docentes.Add(new Docente("Lucas", "Rodriguez", 100, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Ezquiel", "Oggins", 101, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Martina", "Lopez", 102, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Cristian", "Baus", 103, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Ayelen", "Tobias", 104, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Marcela", "Castillo", 105, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Delfina", "Cohen", 106, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Octavio", "Vallegas", 107, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));


            // alumnos sin aula lista
            this.ListaAlumnos();

            //aula hardcoedeadeas
            this.aulas.Add(new Aula(Ecolor.Amarillo, Eturno.Mañana, docentes[0]));
            this.aulas.Add(new Aula(Ecolor.Amarillo, Eturno.Tarde, docentes[1]));
            this.aulas.Add(new Aula(Ecolor.Naranja, Eturno.Mañana, docentes[2]));
            this.aulas.Add(new Aula(Ecolor.Naranja, Eturno.Tarde, docentes[3]));
            //this.aulas.Add(new Aula(Ecolor.Verde, Eturno.Mañana, docentes[4]));
            //this.aulas.Add(new Aula(Ecolor.Verde, Eturno.Tarde, docentes[5]));
            //this.aulas.Add(new Aula(Ecolor.Rojo, Eturno.Mañana, docentes[6]));
            //this.aulas.Add(new Aula(Ecolor.Rojo, Eturno.Tarde, docentes[7]));

            // argego docente creado en form docente




        }



        public List<Aula> Aulas
        {
            get { return this.aulas; }
          
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


            

            //agrego los docentes al aula
            AgregarDocentesAula(this.aulas);



            //agrego los aulmnos al aula validar que sean la misma cantidad de aula.
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[0], 0, 5);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[1], 0, 5);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[2], 0, 5);
            this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[3], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[4], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[5], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[6], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[7], 0, 5);

            //cargo la lista alumnos a listbox muestro la lista despues de haber agregado los alumnos al alua por que se eliminan de la lista
            this.CargarAlumnosSinAula();

            //Agrego la lista de docentes sin aula a listbox
            this.CargarDocentes(this.docentes,this.aulas);
        }

        //Agrego la lista de docentes sin aula a listbox
        public void CargarDocentes(List<Docente> docentes,List<Aula> aulas)
        {
            //listProfesoresDisponibles.Items.Clear();// limpiamos la lista 
            bool esIgual;

            foreach (Docente docente in docentes)
            {
                esIgual = false;

                foreach (Aula aula in aulas)
                {
                    if ( docente.Dni == aula.Docente.Dni)
                    {
                        esIgual = true;
                    }

                   
                }

                if (!esIgual)
                {
                    listProfesoresDisponibles.Items.Add(docente.ToString());
                }
            }

            
        }



        //Agrego a la lista de alumnos sin aulta a la listbox
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

        //agrego un conjunto de alumnos a una sala
        public bool AgregarAlumnoAula(List<Alumno> alumnos,Aula aula,int minimo,int maximo)
        {
            bool agrego = false;
            //para aregarlos al aula cuando se crean los alumnos y borro los que se pasan
            for (int i=minimo;i<maximo;i++)
            {
                        if(aula + alumnos[i])
                        {
                        agrego = true;
                    
                        }
            }
            // una vez agregadas las elimino de la lista
            alumnos.RemoveRange(minimo, maximo);

            return agrego;
        }

        //Agrega los alumnos que tienen aula asignada.
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

        //Agrega docentes creados a la lista de docentes
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

        //Agrega alumnos creados a la lista de alumnos
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


        //Agrega los docentes que estan asignados a un aula en el cmbox
        public void AgregarDocentesAula(List<Aula> a)
        {
            //agergar el docente de aula


            this.cmbProfesor.Items.Clear();

            foreach (Aula item in a)
            {
                //paso un un docente por cada aula
                
                this.cmbProfesor.Items.Add(item.Docente.Nombre + "-"+item.Docente.Apellido);

            }

            
        }

       //agrego un docente de la lista de  docentes  a la de  un aula.
        //public void AgregarDocentesAula(Aula aula, Docente docente)
        //{
        //   aula= new Aula()
        //}


        //boton actualizar
        private void button1_Click(object sender, EventArgs e)
        {

            
            // dependiedo del color cambia el form. y muestra los alumnos en la sala
            if (this.cmbColor.SelectedIndex + 1 == (int)Ecolor.Naranja)
            {
                this.BackColor = Color.Orange;

                if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[2].Docente.Nombre + "-" + this.aulas[2].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[2].Turno.ToString())
                {
                    this.lbProfeAula.Text = "";
                    this.lbProfeAula.Text = this.cmbProfesor.SelectedItem.ToString();

                    this.listAlumnosSala.Items.Clear();
                    AgregarAulaList(this.aulas[2]);

                }
                else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[3].Docente.Nombre + "-" + this.aulas[3].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[3].Turno.ToString())
                {
                    this.lbProfeAula.Text = "";
                    this.lbProfeAula.Text = this.cmbProfesor.SelectedItem.ToString();
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

                if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[6].Docente.Nombre + "-" + this.aulas[6].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[6].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();
                    AgregarAulaList(this.aulas[6]);

                }
                else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[7].Docente.Nombre + "-" + this.aulas[7].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[7].Turno.ToString())
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

                    if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[0].Docente.Nombre + "-" + this.aulas[0].Docente.Apellido && this.cmbTurno.SelectedItem.ToString()== this.aulas[0].Turno.ToString())
                    {
                        this.listAlumnosSala.Items.Clear();
                        AgregarAulaList(this.aulas[0]);
                        
                    }else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[1].Docente.Nombre + "-" + this.aulas[1].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[1].Turno.ToString())
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

                if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[4].Docente.Nombre + "-" + this.aulas[4].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[4].Turno.ToString())
                {
                    this.listAlumnosSala.Items.Clear();
                    AgregarAulaList(this.aulas[4]);

                }
                else if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[5].Docente.Nombre + "-" + this.aulas[5].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[5].Turno.ToString())
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
            this.alumnosSinAula.Add(new Alumno("Turner", "Ockenden", 43713946, true, 26884));
            this.alumnosSinAula.Add(new Alumno("Karlik","Burniston",41198442,false,26649));
            this.alumnosSinAula.Add(new Alumno("Mattias", "Bugg", 44163484, true, 27340));
            this.alumnosSinAula.Add(new Alumno("Davide", "Cutress", 44354291, true, 27962));
            this.alumnosSinAula.Add(new Alumno("Eugine", "Langstaff", 42325666, true, 25724));
            this.alumnosSinAula.Add(new Alumno("Jocelyne", " Dwerryhouse", 42075958, true, 26241));
            this.alumnosSinAula.Add(new Alumno("Fair", "Dickie", 44832164, false, 27644));
            this.alumnosSinAula.Add(new Alumno("Gratiana", "Lydon", 39343636, true, 25060));
            this.alumnosSinAula.Add(new Alumno("Baird", " Nicholson",42207205,true,25230));
            this.alumnosSinAula.Add(new Alumno("Fenelia", " Girardeau",41426116,false,27770));
            this.alumnosSinAula.Add(new Alumno("Thorvald", " Parfett",39984062,false,25291));
            this.alumnosSinAula.Add(new Alumno("Leila", " Mitchard",43210852,false,26140));
            this.alumnosSinAula.Add(new Alumno("Jennifer", " Frow",41667288,true,26799));
            this.alumnosSinAula.Add(new Alumno("Ty","Dear", 42638266,true,27503));
            this.alumnosSinAula.Add(new Alumno("Antin", " Hucke",39912506,true,27767));
            this.alumnosSinAula.Add(new Alumno("Maridel", "Duckett",39998656,false,26073));
            this.alumnosSinAula.Add(new Alumno("Isa", " Goldie",42281327,false,25888));
            this.alumnosSinAula.Add(new Alumno("Bertie", " Klimpt",44292211,true,25349));
            this.alumnosSinAula.Add(new Alumno("Hamish", " Holdall",39874116,false,25449));
            this.alumnosSinAula.Add(new Alumno("Cammy", " McLewd",40817272,true,25389));
            this.alumnosSinAula.Add(new Alumno("Coralie", " Afield",39246075,false,27645));
            this.alumnosSinAula.Add(new Alumno("Wilt", " Cosgrave",43430327,true,25205));
            this.alumnosSinAula.Add(new Alumno("Xylia", " Haggarth",43585611,false,25709));
            this.alumnosSinAula.Add(new Alumno("Aaren", " Briscow",41726291,true,27749));
            this.alumnosSinAula.Add(new Alumno("Florrie","Ianiello",39632747,false,26811));
            this.alumnosSinAula.Add(new Alumno("Jeramey","Viney",43491911,true,25438));
            this.alumnosSinAula.Add(new Alumno("Jannel","Huggen",42549576,false,27599));
            this.alumnosSinAula.Add(new Alumno("Wilow","Gawkroge",43652456,false,27208));
            this.alumnosSinAula.Add(new Alumno("Heda","Harbottle",42213470,true,26998));
            this.alumnosSinAula.Add(new Alumno("Clarissa","Curnokk",40753400,true,25649));
            this.alumnosSinAula.Add(new Alumno("Sidonia","Beretta",41517098,false,26725));
            this.alumnosSinAula.Add(new Alumno("Lamont2","Dusey",42664812,false,25107));
            this.alumnosSinAula.Add(new Alumno("Fidelity","Ivanilov",40331835,true,25732));
            this.alumnosSinAula.Add(new Alumno("Berkley","Bolens",44922752,true,26309));
            this.alumnosSinAula.Add(new Alumno("Caressa","Saylor",41370220,true,25244));
            this.alumnosSinAula.Add(new Alumno("Myrna","Deinhard",40516132,false,26599));
            this.alumnosSinAula.Add(new Alumno("Freddie","Headingham",43353900,true,26419));
            this.alumnosSinAula.Add(new Alumno("Emylee","Saill",39764679,true,27239));
            this.alumnosSinAula.Add(new Alumno("Kyle","Titcom",42930634,false,25686));
            this.alumnosSinAula.Add(new Alumno("Ricca","Guidera",39848839,true,25860));
            this.alumnosSinAula.Add(new Alumno("Beauregard","Gouck",39353120,false,27637));
            this.alumnosSinAula.Add(new Alumno("Edgar","Krink",44596906,false,26460));
            this.alumnosSinAula.Add(new Alumno("Farra","Spain",44713847,false,25064));
            this.alumnosSinAula.Add(new Alumno("Aubrey","Rouge",39217977,true,25770));
            this.alumnosSinAula.Add(new Alumno("Kissiah","Angeau",44221782,false,27267));
            this.alumnosSinAula.Add(new Alumno("Agata","Donet",44711503,false,27510));
            this.alumnosSinAula.Add(new Alumno("Maris","Cheson",43199252,false,25266));
            this.alumnosSinAula.Add(new Alumno("Norris","Brocket",39558498,false,25348));
            this.alumnosSinAula.Add(new Alumno("Kalindi","Glazebrook",43781151,true,27176));
            this.alumnosSinAula.Add(new Alumno("Allissa", "Zanetto", 40724467, false, 26902));



        }

        private void btnGuardarAula_Click(object sender, EventArgs e)
        {
            //if()
            //aula = new Aula()

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
