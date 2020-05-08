using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public abstract class Personal : Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;

        protected Personal(string nombre, string apellido, int dni, bool femenino,DateTime horaEntrada,DateTime horaSalida):base(nombre,apellido,dni,femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }

        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaSalida = value; }
        }
        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        public double Salario
        {
            get { return this.CalcularSalario(); }
      
        }

        protected abstract double CalcularSalario();

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            
            datos.Append(base.ToString());
            datos.AppendLine($"{this.HoraEntrada.ToShortTimeString()}-");
            datos.AppendLine($"{this.horaSalida.ToShortTimeString()}-");
            datos.AppendLine($"{this.Salario}-");

            return datos.ToString();

        }
    }
}
