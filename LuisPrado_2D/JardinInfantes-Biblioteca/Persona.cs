using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public abstract class Persona
    {

        private string apellido;
        private int dni;
        private bool femenino;
        private string nombre;

        protected Persona(string nombre,string apellido,int dni) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        protected Persona(string nombre, string apellido, int dni,bool femenino):this(nombre,apellido,dni)
        {
            this.femenino = femenino;
        }


        public string  Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"{this.Nombre}-");
            datos.AppendLine($"{this.Apellido}-");
            datos.AppendLine($"{this.Dni}-");
            datos.AppendLine($"{Validaciones.ValidarSexo(this.Femenino)}-");
            

            return datos.ToString();

        }


    }
    
}

