using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public class Docente : Personal
    {

        private double valorHora;
        

        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }
        public int HorasMensuales
        {

            get {
                int cantidadHora;
               

                    cantidadHora = this.HoraSalida.Subtract(this.HoraEntrada).Hours;

                    return cantidadHora * 20;
                 }
           
        }

        public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida,double valorHora) : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.valorHora = valorHora;
        }

        protected override double CalcularSalario()
        {
            
            double resultado;
            resultado = this.HorasMensuales * this.ValorHora;
            return resultado;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            
            datos.AppendLine(base.ToString());
           

            return datos.ToString();
        }
    }
}
