using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public class Alumno : Persona
    {
        private Ecolor colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;
        

        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public Ecolor ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }

        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota) : base(nombre, apellido, dni, femenino)
        {
            this.precioCuota = precioCuota;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return a1.legajo == a2.legajo;

        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public static implicit operator Responsable(Alumno a)
        {
           
            return a.Responsable;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            
            datos.Append(base.ToString());
            datos.AppendLine($"{this.ColorSala}");
            datos.AppendLine($"{this.Legajo}");
            datos.AppendLine($"{this.Responsable}");
            datos.AppendLine($"{this.PrecioCuota}");
            

            return datos.ToString();

        }

    }
}
