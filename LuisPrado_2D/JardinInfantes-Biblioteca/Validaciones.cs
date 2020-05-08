using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public class Validaciones
    {
        public static string ValidarSexo(bool sexo)
        {
            if (sexo)
            {
                return "Femenino";
            }
            else
            {
                return "Masculino";
            }
        }
    }
}
