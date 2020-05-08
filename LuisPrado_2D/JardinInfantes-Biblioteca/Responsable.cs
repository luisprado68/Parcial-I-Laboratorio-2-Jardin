using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public class Responsable : Persona
    {

        private Eparentezco parentezco;
        private string telefono;

        public Responsable(string nombre, string apellido, int dni, bool femenino, Eparentezco parentezco,string telefono) : base(nombre, apellido, dni, femenino)
        {
            this.parentezco = parentezco;
            this.telefono = telefono;
        }

        public Eparentezco Parentezco
        {
            get { return this.parentezco; }
            set { this.parentezco = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

           
            datos.Append(base.ToString());
            datos.AppendLine($"Parentezco:{this.Parentezco}");
            datos.AppendLine($"Telefono:{this.Telefono}");
           
            return datos.ToString();
        }


    }
}
