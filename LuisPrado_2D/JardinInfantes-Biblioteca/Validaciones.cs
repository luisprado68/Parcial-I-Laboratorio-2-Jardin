using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

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

        public static bool ValidarString(string s)
        {
            return !(string.IsNullOrEmpty(s));
        }

        public static bool ValidarDouble(string s, double max, double min)
        {

            return (double.TryParse(s, out double numeroARetornar) && numeroARetornar >= min && numeroARetornar < max);
        }
        public static bool ValidarEntero(string s, int max, int min)
        {
            return (int.TryParse(s, out int numeroARetornar) && numeroARetornar >= min && numeroARetornar < max);
        }

        public static bool ValidarParentezco(string parentezco)
        {
            if(parentezco == Eparentezco.Abuela.ToString())
            {
                return true;
            }
            else if (parentezco == Eparentezco.Abuelo.ToString())
            {
                return true;
            }
            else if (parentezco == Eparentezco.Madre.ToString())
            {
                return true;
            }
            else if (parentezco == Eparentezco.Otro.ToString())
            {
                return true;
            }
            else if (parentezco == Eparentezco.Padre.ToString())
            {
                return true;
            }
            else if (parentezco == Eparentezco.Tía.ToString())
            {
                return true;
            }
            else if (parentezco == Eparentezco.Tío.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Eparentezco pariente(string parentezco)
        {
            if (parentezco == Eparentezco.Abuela.ToString())
            {
                return Eparentezco.Abuela;
            }
            else if (parentezco == Eparentezco.Abuelo.ToString())
            {
                return Eparentezco.Abuelo;
            }
            else if (parentezco == Eparentezco.Madre.ToString())
            {
                return Eparentezco.Madre;
            }
            else if (parentezco == Eparentezco.Otro.ToString())
            {
                return Eparentezco.Otro;
            }
            else if (parentezco == Eparentezco.Padre.ToString())
            {
                return Eparentezco.Padre;
            }
            else if (parentezco == Eparentezco.Tía.ToString())
            {
                return Eparentezco.Tía;
            }
            else
            {
                return Eparentezco.Tío;

            }
        }
        public static bool ValidarLetras(string palabra)
        {
            if (palabra == string.Empty)
            {
                return false;
            }
            else
            {
                foreach (char ch in palabra)
                {

                    if (!Char.IsLetter(ch) && ch != 32)
                    {
                        return false;
                    }
                }
                return true;
            }
                

        }
    }


}
