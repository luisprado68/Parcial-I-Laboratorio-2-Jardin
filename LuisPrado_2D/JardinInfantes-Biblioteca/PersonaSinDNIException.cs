using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinInfantes_Biblioteca
{
    public class PersonaSinDNIException:Exception
    {
        public PersonaSinDNIException(string mensaje,Exception innerException) : base(mensaje, innerException)
        {

        }

        public PersonaSinDNIException(string mensaje) : base(mensaje)
        {

        }
    }
}
