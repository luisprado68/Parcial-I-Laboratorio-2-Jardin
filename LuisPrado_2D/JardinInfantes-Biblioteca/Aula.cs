using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public class Aula
    {
        private List<Alumno> alumnos;
        private Ecolor colorSala;
        private Docente docente;
        private Eturno turno;

        public Aula()
        {
            this.alumnos = new List<Alumno>();
        }

        public Aula(Ecolor colorSala,Eturno turno,Docente docente):this()
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public Ecolor ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }

        public Eturno Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }

        public static bool operator +(Aula a, Alumno al)
        {
            bool esIgual=false;
            foreach (Alumno item in a.alumnos)
            {
                if(al == item)
                {
                    esIgual = true;
                }
            }

            if (!esIgual)
            {
                if(a.alumnos.Count < 30)
                {
                    al.ColorSala = a.ColorSala;
                    al.Legajo = al.Dni + 5;
                    a.alumnos.Add(al);
                    return true;
                }
                
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Color Sala:{this.ColorSala}");
            datos.AppendLine($"Turno:{this.Turno}");
            datos.AppendLine($"Docente:{this.Docente}");

            foreach (Alumno item in this.Alumnos)
            {
                datos.AppendLine(item.ToString());
            }

            return datos.ToString();
        }

        
    }
}
