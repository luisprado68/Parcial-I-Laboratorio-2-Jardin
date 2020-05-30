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
using System.Media;

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
        SoundPlayer sonido;

        public FrmAula()
        {
            InitializeComponent();
            docentes = new List<Docente>();
            alumnosSinAula = new List<Alumno>();
            aulas = new List<Aula>();

            //Docentes sin Aula lista
            this.docentes.Add(new Docente("Lucas", "Rodriguez", 41208541, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220));
            this.docentes.Add(new Docente("Ezquiel", "Oggins", 41208542, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 210));
            this.docentes.Add(new Docente("Martina", "Lopez", 41208543, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 200));
            this.docentes.Add(new Docente("Cristian", "Baus", 41208544, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 180));
            this.docentes.Add(new Docente("Ayelen", "Tobias", 41208545, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 200));
            this.docentes.Add(new Docente("Marcela", "Castillo", 41208546, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 300));
            this.docentes.Add(new Docente("Delfina", "Cohen", 41208547, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 190));
            this.docentes.Add(new Docente("Octavio", "Vallegas", 41208548, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 210));


            // alumnos sin aula lista

            Responsable r1 = new Responsable("Juan", "Prado", 41208549, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Luis", "Prado", 41208550, false, 25000, r1));
            Responsable r2 = new Responsable("Sara", "Prado", 41208551, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Maria", "Prado", 41208552, true, 25000, r2));
            Responsable r3 = new Responsable("Martin", "Prado", 41208553, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Laura", "Prado", 41208554, true, 25000, r3));
            Responsable r4 = new Responsable("Marta", "Rodriguez", 41208555, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Mateo", "Stigliano", 41208556, false, 25000, r4));
            Responsable r5 = new Responsable("Joaquin", "Lopez", 41208557, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Valentina", "Lopez", 41208558, true, 25000, r5));
            Responsable r6 = new Responsable("Laura", "Garcia", 41208559, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Martin", "Garcia", 41208560, false, 25000, r6));
            Responsable r7 = new Responsable("Martin", "Garcia", 41208561, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Graciela", "Garcia", 41208562, true, 25000, r7));
            Responsable r8 = new Responsable("Sara", "Chavez", 41208563, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Jazmin", "Chavez", 41208564, true, 25000, r8));
            Responsable r9 = new Responsable("Juan", "Chavez", 41208565, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Matias", "Chavez", 41208566, false, 25000, r9));
            Responsable r10 = new Responsable("Karen", "Martinez", 41208567, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Nicolas", "Miloro", 41208568, false, 25000, r10));
            Responsable r11 = new Responsable("Kevin", "Guzman", 41208569, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Lucia", "Finochi", 41208570, true, 25000, r11));
            Responsable r12 = new Responsable("Jimena", "Palacios", 41208571, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Leticia", "Garcia", 41208572, true, 25000, r12));
            Responsable r13 = new Responsable("Alberto", "Maas", 41208573, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Julieta", "Maas", 41208574, true, 25000, r13));
            Responsable r14 = new Responsable("Leticia", "Lopez", 41208575, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Nicole", "Ferreyra", 41208576, true, 25000, r14));
            Responsable r15 = new Responsable("Luis", "Gimenez", 41208577, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Luna", "Herrera", 41208578, true, 25000, r15));
            Responsable r16 = new Responsable("Miriam", "Niez", 41208579, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Kael", "Alessandroni", 41208580, false, 25000, r16));
            Responsable r17 = new Responsable("Miguel ", "Vázquez ", 41208581, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Martin", "Prado", 41208582, false, 25000, r17));
            Responsable r18 = new Responsable("Alejandro", "Lara", 41208583, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Mauro", "Lara", 41208584, false, 25000, r18));
            Responsable r19 = new Responsable("Martin", "Montero", 41208585, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Ezequiel", "Montero", 41208586, false, 25000, r19));
            Responsable r20 = new Responsable("Jimena", "Lopex", 41208587, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Florencia", "Gonzales", 41208588, true, 25000, r20));
            Responsable r21 = new Responsable("Matias", "Gimenez", 41208589, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Marcela", "Gimenez", 41208590, true, 25000, r21));
            Responsable r22 = new Responsable("Laura", "Cleres", 41208591, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Gonzalo", "Montenegro", 41208592, false, 25000, r22));
            Responsable r23 = new Responsable("Jaime ", "Guanajuato", 41208593, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Etelvina", "Cleres", 41208594, true, 25000, r23));
            Responsable r24 = new Responsable("Andrea", "González", 41208595, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Daniel", "Gorostiaga", 41208596, false, 25000, r24));
            Responsable r25 = new Responsable("Ruth ", "Ariana", 41208597, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Turner", "Ockenden", 41208598, true, 26884, r25));
            Responsable r26 = new Responsable("Andres", "Burniston", 41208599, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Karlik", "Burniston", 41208600, false, 26649, r26));
            Responsable r27 = new Responsable("Lisset ", "Potosí", 41208601, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Mattias", "Bugg", 41208602, true, 27340, r27));
            Responsable r28 = new Responsable("Erlich", "Cutress", 41208603, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Davide", "Cutress", 41208604, true, 27962, r28));
            Responsable r29 = new Responsable("Verónica", "Jonacatepec", 41208605, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Eugine", "Langstaff", 41208606, true, 25724, r29));
            Responsable r30 = new Responsable("Cipriano ", "Dwerryhouse", 41208607, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Jocelyne", " Dwerryhouse", 41208608, true, 26241, r30));
            Responsable r31 = new Responsable("Morelia", "Vianey", 41208609, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Fair", "Dickie", 41208610, false, 27644, r31));
            Responsable r32 = new Responsable("Hernan", "Lydon", 41208611, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Gratiana", "Lydon", 41208612, true, 25060, r32));
            Responsable r33 = new Responsable("Bestriz", "Klein", 41208613, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Baird", " Nicholson", 41208614, true, 25230, r33));
            Responsable r34 = new Responsable("Leonel", "Girardeau", 41208615, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Fenelia", " Girardeau", 41208616, false, 27770, r34));
            Responsable r35 = new Responsable("Luciana", "Chavez", 41208617, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Thorvald", " Parfett", 41208618, false, 25291, r35));
            Responsable r36 = new Responsable("Fernando", "Mitchard", 41208619, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Leila", " Mitchard", 41208620, false, 26140, r36));
            Responsable r37 = new Responsable("Danna", "Prado", 41208621, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Jennifer", " Frow", 41208622, true, 26799, r37));
            Responsable r38 = new Responsable("Alejandro", "Dear", 41208623, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Ty", "Dear", 41208624, true, 27503, r38));
            Responsable r39 = new Responsable("Verónica", "Palacios", 41208625, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Antin", " Hucke", 41208626, true, 27767, r39));
            Responsable r78 = new Responsable("Miguel ", "Duckett", 41208627, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Maridel", "Duckett", 41208628, false, 26073, r78));
            Responsable r40 = new Responsable("Sarai", "Álvarez", 41208629, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Isa", " Goldie", 41208630, false, 25888, r40));
            Responsable r41 = new Responsable("Ignacio", "Klimpt", 41208631, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Bertie", " Klimpt", 41208632, true, 25349, r41));
            Responsable r42 = new Responsable("Lisset ", "Flores ", 41208633, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Hamish", " Holdall", 41208634, false, 25449, r42));
            Responsable r43 = new Responsable("Felipe", "McLewd", 41208635, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Cammy", " McLewd", 41208636, true, 25389, r43));
            Responsable r44 = new Responsable("Ariana","Gonzalez",41208637,true,Eparentezco.Madre,"1550238312");
            this.alumnosSinAula.Add(new Alumno("Coralie", " Afield", 41208638, false, 27645, r44));
            Responsable r45 = new Responsable("Francisco", "Cosgrave", 41208639, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Wilt", " Cosgrave", 41208640, true, 25205, r45));
            Responsable r46 = new Responsable("Morelia", "Santa ", 41208641, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Xylia", " Haggarth", 41208642, false, 25709, r46));
            Responsable r47 = new Responsable("Daniel", "Briscow", 41208643, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Aaren", " Briscow", 41208644, true, 27749, r47));
            Responsable r48 = new Responsable("Abigali", "Puebla", 41208645, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Florrie", "Ianiello", 41208646, false, 26811, r48));
            Responsable r49 = new Responsable("Esteban", "Viney", 41208647, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Jeramey", "Viney", 41208648, true, 25438, r49));
            Responsable r50 = new Responsable("Carolina", "Fuentes", 41208649, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Jannel", "Huggen", 41208650, false, 27599, r50));
            Responsable r51 = new Responsable("Itzel", "Huanímaro",41208651,false,Eparentezco.Padre,"1550238312");
            this.alumnosSinAula.Add(new Alumno("Wilow", "Gawkroge", 41208652, false, 27208, r51));
            Responsable r52 = new Responsable("Adriana ", "Guanajuato", 41208653, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Heda", "Harbottle", 41208654, true, 26998, r52));
            Responsable r53 = new Responsable("Yaír ", "Aguascalientes", 41208655, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Clarissa", "Curnokk", 41208656, true, 25649, r53));
            Responsable r54 = new Responsable("María", "Pérez", 41208657, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Sidonia", "Beretta", 41208658, false, 26725, r54));
            Responsable r55 = new Responsable("Pablo", "Morelia", 41208659, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Lamont2", "Dusey", 41208660, false, 251007, r55));
            Responsable r56 = new Responsable("Julia ", "León", 41208661, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Fidelity", "Ivanilov", 41208662, true, 25732, r56));
            Responsable r57 = new Responsable("Fernando", "Guzman", 41208663, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Berkley", "Bolens", 41208664, true, 26309, r57));
            Responsable r58 = new Responsable("Samanta", "Cuernavaca", 41208665, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Caressa", "Saylor", 41208666, true, 25244, r58));
            Responsable r59 = new Responsable("Daniel", "Colima", 41208667, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Myrna", "Deinhard", 41208668, false, 26599, r59));
            Responsable r60 = new Responsable("Danna ", "Hernández ", 41208669, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Freddie", "Headingham", 41208670, true, 26419, r60));
            Responsable r61 = new Responsable("Ignacio", "Saill", 41208671, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Emylee", "Saill", 41208672, true, 27239, r61));
            Responsable r62 = new Responsable("Lisset ", "Vianey", 41208673, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Kyle", "Titcom", 41208674, false, 25686, r62));
            Responsable r63 = new Responsable("José ", "Vargas", 41208675, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Ricca", "Guidera", 41208676, true, 25860, r63));
            Responsable r64 = new Responsable("Karla ", "Paulette", 41208677, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Beauregard", "Gouck", 41208678, false, 27637, r64));
            Responsable r65 = new Responsable("Hansel ", "Ramos", 41208679, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Edgar", "Krink", 41208680, false, 26460, r65));
            Responsable r66 = new Responsable("Agata", "Glazebrook", 41208681, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Farra", "Spain", 41208682, false, 25064, r66));
            Responsable r67 = new Responsable("Felipe", "Gonzales", 41208683, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Aubrey", "Rouge", 41208684, true, 25770, r67));
            Responsable r68 = new Responsable("Ruth ", "Lagunes", 41208685, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Kissiah", "Angeau", 41208686, false, 27267, r68));
            Responsable r69 = new Responsable("Francisco", "Cortés ", 41208687, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Agata", "Donet", 41208688, false, 27510, r69));
            Responsable r70 = new Responsable("Andrea", "Chávez ", 41208689, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Maris", "Cheson", 41208690, false, 25266, r70));
            Responsable r71 = new Responsable("Jaime ", "González", 41208691, false, Eparentezco.Padre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Norris", "Brocket", 41208692, false, 25348, r71));
            Responsable r72 = new Responsable("Silvia", "Aguirre", 41208693, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Kalindi", "Glazebrook", 41208694, true, 27176, r72));
            Responsable r73 = new Responsable("Delfina", "Lopez", 41208695, true, Eparentezco.Madre, "1550238312");
            this.alumnosSinAula.Add(new Alumno("Allissa", "Zanetto", 41208696, false, 269025, r73));

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

            //agrego los aulmnos al aula validar que sean la misma cantidad de aula.
            this.AgregarAlumnosAula(this.alumnosSinAula, this.aulas[0], 0, 5);
            this.AgregarAlumnosAula(this.alumnosSinAula, this.aulas[1], 0, 5);
            this.AgregarAlumnosAula(this.alumnosSinAula, this.aulas[2], 0, 5);
            this.AgregarAlumnosAula(this.alumnosSinAula, this.aulas[3], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[4], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[5], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[6], 0, 5);
            //this.AgregarAlumnoAula(this.alumnosSinAula, this.aulas[7], 0, 5);




        }

        public List<Aula> Aulas
        {
            get { return this.aulas; }
          
        }

        public FrmAula(Docente docente):this()
        {
            this.unDocente = docente;
            this.AgregarDocenteAListaDocente(this.docentes, this.unDocente);

        }

        public FrmAula(Alumno alumno):this()
        {
            this.unAlumno = alumno;
            this.AgregarAlumnoListaAlumnos(this.alumnosSinAula, this.unAlumno);
        }

        public FrmAula(Docente docente,Alumno alumno) : this()
        {
            this.unDocente = docente;
            this.unAlumno = alumno;
            this.AgregarDocenteAListaDocente(this.docentes, this.unDocente);
            this.AgregarAlumnoListaAlumnos(this.alumnosSinAula, this.unAlumno);

        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            this.MostrarAulas(this.aulas);//muestro las aulas en el combobox Aulas.

            this.AgregarDocentesAula(this.aulas);//muestro los docentes con aula en el combobox

            //cargo la lista alumnos a listbox muestro la lista despues de haber agregado los alumnos al alua por que se eliminan de la lista
            this.CargarAlumnosSinAulaListBox();

            //Agrego la lista de docentes sin aula a listbox
            this.CargarDocentesSinAulaListBox(this.docentes,this.aulas);
        }

        //Agrega los docentes que estan asignados a un aula en el cmbox
        public void AgregarDocentesAula(List<Aula> a)
        {
            //agergar el docente de aula

            this.cmbProfesor.Items.Clear();

            foreach (Aula item in a)
            {
                //paso un un docente por cada aula

                this.cmbProfesor.Items.Add(item.Docente.Nombre + "-" + item.Docente.Apellido);

            }


        }
        public void MostrarAulas(List<Aula> aulas)
        {
            this.listAulasActuales.Items.Clear();
            foreach (Aula item in aulas)
            {
                this.listAulasActuales.Items.Add("Sala "+item.ColorSala+" - Turno "+item.Turno+" - "+item.Docente.Nombre+" - "+item.Docente.Apellido);
            }
        }
        //Agrego la lista de docentes sin aula a listbox
        public void CargarDocentesSinAulaListBox(List<Docente> docentes,List<Aula> aulas)
        {
            listProfesoresDisponibles.Items.Clear();
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



        //Agrego a la lista de alumnos sin aula a la listbox
        public void CargarAlumnosSinAulaListBox()
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

        //agrego un conjunto de alumnos a una sala y  borro de la lista
        public bool AgregarAlumnosAula(List<Alumno> alumnos,Aula aula,int minimo,int maximo)
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

        //Agrega los alumnos que tienen aula asignada a listbox.
        public void AgregarAlumnosEnSalaListBox(Aula aula)
        {
            listAlumnosSala.Items.Clear();
            foreach (Alumno item in aula.Alumnos)
            {
                if (aula.Alumnos.Count != 0)
                {
                    listAlumnosSala.Items.Add(item.ToString());
                    
                }

            }
        }

        //Agrega docentes creados a la lista de docentes
        public bool AgregarDocenteAListaDocente(List<Docente> l,Docente d)
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
        public bool AgregarAlumnoListaAlumnos(List<Alumno> lista,Alumno a)
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


        //boton actualizar
        private void button1_Click(object sender, EventArgs e)
        {
            bool encontroAula = false;

            if (this.cmbColor.SelectedIndex == -1)
            {
                MessageBox.Show("PARA VER AULA SELECCIONAR: COLOR DE SALA - TURNO - PROFESOR EN AULA");

            }
            else if (this.cmbTurno.SelectedIndex == -1)
            {
                MessageBox.Show("PARA VER AULA SELECCIONAR: COLOR DE SALA - TURNO - PROFESOR EN AULA");
            }
            else if (this.cmbProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("PARA VER AULA SELECCIONAR: COLOR DE SALA - TURNO - PROFESOR EN AULA");
            }
            else if (this.cmbColor.SelectedIndex + 1 == (int)Ecolor.Naranja)
            {
                
                for (int i = 0; i < this.aulas.Count; i++)
                {
                    
                    if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[i].Docente.Nombre + "-" + this.aulas[i].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[i].Turno.ToString() && this.cmbColor.SelectedItem.ToString()==this.aulas[i].ColorSala.ToString())
                    {
                        this.BackColor = Color.Orange;
                       
                        encontroAula = true;
                        AgregarAlumnosEnSalaListBox(this.aulas[i]);
                        MostrarAulas(this.aulas);
                    }
                }

                if (!encontroAula)
                {
                    MessageBox.Show("NO EXISTE AULA CON ESOS PARAMETROS!");
                }

            }
            else if (this.cmbColor.SelectedIndex + 1== (int)Ecolor.Rojo)
            {
                // mejora buscar en la lista de aulas por docente.
                
                for (int i=0;i<this.aulas.Count;i++)
                {
                    
                    if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[i].Docente.Nombre + "-" + this.aulas[i].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[i].Turno.ToString() && this.cmbColor.SelectedItem.ToString() == this.aulas[i].ColorSala.ToString())
                    {
                        this.BackColor = Color.Red;
                        encontroAula = true;
                        AgregarAlumnosEnSalaListBox(this.aulas[i]);
                        MostrarAulas(this.aulas);
                    }
                }

                if (!encontroAula)
                {
                    MessageBox.Show("NO EXISTE AULA CON ESOS PARAMETROS!");
                }
            }
            else if (this.cmbColor.SelectedIndex + 1 == (int)Ecolor.Amarillo)
            {    // depediendo de colo profesoy y turno muestra:
                
                for (int i = 0; i < this.aulas.Count; i++)
                {
                    
                    if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[i].Docente.Nombre + "-" + this.aulas[i].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[i].Turno.ToString() && this.cmbColor.SelectedItem.ToString() == this.aulas[i].ColorSala.ToString())
                    {
                        this.BackColor = Color.Yellow;
                        encontroAula = true;
                        AgregarAlumnosEnSalaListBox(this.aulas[i]);
                        MostrarAulas(this.aulas);
                    }
                }
                if (!encontroAula)
                {
                    MessageBox.Show("NO EXISTE AULA CON ESOS PARAMETROS!");
                }

            }
            else if (this.cmbColor.SelectedIndex+1 == (int)Ecolor.Verde)
            {
                
                for (int i = 0; i < this.aulas.Count; i++)
                {
                    
                    if (this.cmbProfesor.SelectedItem.ToString() == this.aulas[i].Docente.Nombre + "-" + this.aulas[i].Docente.Apellido && this.cmbTurno.SelectedItem.ToString() == this.aulas[i].Turno.ToString() && this.cmbColor.SelectedItem.ToString() == this.aulas[i].ColorSala.ToString())
                    {
                        this.BackColor = Color.Green;
                        encontroAula = true;
                        AgregarAlumnosEnSalaListBox(this.aulas[i]);
                        MostrarAulas(this.aulas);
                    }
                }
                if (!encontroAula)
                {
                    MessageBox.Show("NO EXISTE AULA CON ESOS PARAMETROS!");
                }
            }

        }

        
        

        private void btnGuardarAula_Click(object sender, EventArgs e)
        {

            Ecolor color;
            Eturno turno;
            int posicion = 0;
           
            int aula=0;
            int alumno = 0;

            if (this.cmbColor.SelectedIndex == -1)
            {
                MessageBox.Show("No se eligio ninguna opcion para agregar un alumno");

            }
            else if (this.cmbTurno.SelectedIndex == -1)
            {
                MessageBox.Show("No se eligio ninguna opcion para agregar un alumno");
            }
            else if (this.cmbProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("No se eligio ninguna opcion para agregar un alumno");
            }
            else if (this.listAlumnosSinAula.SelectedIndex == -1)
            {
                MessageBox.Show("No se eligio ninguna opcion para agregar un alumno");
            }
            else
            {
                if (this.cmbColor.SelectedItem.ToString() == Ecolor.Amarillo.ToString())
                {
                    color = Ecolor.Amarillo;

                }
                else if (this.cmbColor.SelectedItem.ToString() == Ecolor.Naranja.ToString())
                {
                    color = Ecolor.Naranja;

                }
                else if (this.cmbColor.SelectedItem.ToString() == Ecolor.Rojo.ToString())
                {
                    color = Ecolor.Rojo;

                }
                else
                {
                    color = Ecolor.Verde;

                }

                if (this.cmbTurno.SelectedItem.ToString() == Eturno.Mañana.ToString())
                {
                    turno = Eturno.Mañana;

                }
                else
                {
                    turno = Eturno.Tarde;

                }

                //encontarel alumno

                for(int i = 0; i < this.alumnosSinAula.Count; i++)
                {
                    if(this.listAlumnosSinAula.SelectedItem.ToString() == this.alumnosSinAula[i].ToString())
                    {
                        alumno = i;
                    }
                }

                //agrego los de la lista de docentes que cuando se agerga un docente se valida que no se repita.

                for (int i = 0; i < this.docentes.Count; i++)
                {

                    if (this.cmbProfesor.SelectedItem.ToString() == this.docentes[i].Nombre+"-"+this.docentes[i].Apellido)
                    {
                        posicion = i;

                    }

                }
                // encontrar aula actual---

                for (int i=0;i<this.aulas.Count; i++)
                {
                    if(this.aulas[i].ColorSala ==color && this.aulas[i].Turno == turno && this.aulas[i].Docente == this.docentes[posicion])
                    {
                        aula = i;
                    }
                }
                //agrego al aula el alumno seleccionado y encontrado en la lista de alumnos sin aula.
                if (this.aulas[aula] + this.alumnosSinAula[alumno])
                {
                    this.alumnosSinAula.RemoveAt(alumno); ///elimino el alumno de la lista sin asiganar
                    CargarAlumnosSinAulaListBox();//actualizo el lista de alunos sin asignar
                    try
                    {
                        sonido = new SoundPlayer(Application.StartupPath+@"\sonido\sonido.wav");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    MessageBox.Show("Alumnos agregado a la sala");
                   
                }
                else
                {
                    MessageBox.Show("No se  agregado alumno  a la sala");
                }


            }

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void listAlumnosSinAula_MouseMove(object sender, EventArgs e)
        {

        }

        //agregar Docente a Aula

        public bool agregarDocenteAula(List<Aula> aulas,Ecolor color,Eturno turno, Docente docente)
        {
            bool esIgual=false;
          
            Aula aula;
            

            foreach (Aula item in aulas)
            {
                

                if( item.ColorSala == color && item.Turno == turno)
                {
                    esIgual = true;
                }
            }

           
            if (!esIgual)
            {
                aula = new Aula(color, turno, docente);

                aulas.Add(aula);
                // agrego nueva aula a la lista-----------------------------------------

                return true;
            }

            return false;

        }

        
        private void agregarProfesor_Click(object sender, EventArgs e)
        {
           

            Ecolor color;
            Eturno turno;
            int posicion=0;
            

            if(this.cmbColor.SelectedIndex== -1)
            {
                MessageBox.Show("Para Crear un Aula Nueva debe Elegir: Color de Sala - Turno - Profesor Disponible");
                
            }else if( this.cmbTurno.SelectedIndex == -1 )
            {
                MessageBox.Show("Para Crear un Aula Nueva debe Elegir: Color de Sala - Turno - Profesor Disponible");
            }
            else if (this.listProfesoresDisponibles.SelectedIndex == -1 )
            {
                MessageBox.Show("Para Crear un Aula Nueva debe Elegir: Color de Sala - Turno - Profesor Disponible");
            }
            else
            {
                if (this.cmbColor.SelectedItem.ToString() == Ecolor.Amarillo.ToString())
                {
                    color = Ecolor.Amarillo;

                }
                else if (this.cmbColor.SelectedItem.ToString() == Ecolor.Naranja.ToString())
                {
                    color = Ecolor.Naranja;

                }
                else if (this.cmbColor.SelectedItem.ToString() == Ecolor.Rojo.ToString())
                {
                    color = Ecolor.Rojo;

                }
                else
                {
                    color = Ecolor.Verde;

                }


                if (this.cmbTurno.SelectedItem.ToString() == Eturno.Mañana.ToString())
                {
                    turno = Eturno.Mañana;

                }
                else
                {
                    turno = Eturno.Tarde;

                }

                //agrego los de la lista de docentes que cuando se agerga un docente se valida que no se repita.


                for (int i = 0; i < this.docentes.Count; i++)
                {

                    if (listProfesoresDisponibles.SelectedItem.ToString() == this.docentes[i].ToString())
                    {
                        posicion = i;

                    }

                }



                if (agregarDocenteAula(this.aulas, color, turno, this.docentes[posicion]))
                {
                    MessageBox.Show("Se agrego docente a nueva aula creada");
                    AgregarDocentesAula(this.aulas);
                    CargarDocentesSinAulaListBox(this.docentes, this.aulas);


                }
                else
                {
                    MessageBox.Show("Ya se encuentra esa sala - Revisar Aulas Actuales ");
                }


            }

        }

        private void listAlumnosSinAula_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        
    }
}
