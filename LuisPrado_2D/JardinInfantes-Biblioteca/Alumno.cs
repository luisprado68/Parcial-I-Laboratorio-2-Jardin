using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
#pragma warning disable CS0660 // 'Alumno' define el operador == o el operador != pero no invalida Object.Equals(object o)
#pragma warning disable CS0661 // 'Alumno' define el operador == o el operador != pero no invalida Object.GetHashCode()
    public class Alumno : Persona
#pragma warning restore CS0661 // 'Alumno' define el operador == o el operador != pero no invalida Object.GetHashCode()
#pragma warning restore CS0660 // 'Alumno' define el operador == o el operador != pero no invalida Object.Equals(object o)
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

        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota, Responsable responsable) : base(nombre, apellido, dni, femenino)
        {
            this.precioCuota = precioCuota;
            this.responsable = responsable;
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
            if ((int)this.colorSala == 0)
            {
                datos.AppendLine("Sin Aula");
            }
            else
            {
                datos.AppendLine($"{this.ColorSala}");
            }
            
            datos.AppendLine($"{this.Legajo}");
            if(this.responsable is null)
            {
                datos.AppendLine("Sin responsable");
            }
            else
            {
                datos.AppendLine($"{this.Responsable}");
            }
            
            datos.AppendLine($"{this.PrecioCuota}");
            

            return datos.ToString();

        }

    }
}
