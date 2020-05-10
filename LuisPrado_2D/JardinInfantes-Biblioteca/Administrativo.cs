using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public class Administrativo : Personal
    {
       

        private ECargo cargo;
        public static double salarioBase;

         static Administrativo()
        {
            Administrativo.salarioBase = 30000;
        }

        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida,ECargo cargo):base(nombre,apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.cargo = cargo;
        }
      

        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        protected override double CalcularSalario()
        {
            double resultado;
            if (this.cargo == ECargo.Portería)
            {
                return resultado =Administrativo.salarioBase * (double)ECargo.Portería / 100;
            }
            else if (this.cargo == ECargo.Cocina)
            {
                return resultado = Administrativo.salarioBase * (double)ECargo.Cocina / 100;
            }
            else if (this.cargo == ECargo.Secretaría)
            {
                return resultado = Administrativo.salarioBase * (double)ECargo.Secretaría / 100;
            }
            else if (this.cargo == ECargo.Tesorería)
            {
                return resultado = Administrativo.salarioBase * (double)ECargo.Tesorería / 100;
            }
            else
            {
                return resultado = Administrativo.salarioBase * (double)ECargo.Dirección / 100;
            }
            
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();


            datos.Append(base.ToString());
            datos.AppendLine($"Cargo: {this.Cargo}");
           
            


            return datos.ToString();

        }
    }
}
