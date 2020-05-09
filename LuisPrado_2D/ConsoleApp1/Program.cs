using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JardinInfantes_Biblioteca;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prueba de codigo....

            Console.WriteLine(Ecolor.Amarillo.ToString());
            Console.WriteLine();


            //ALTA DOCENTE

            int horaEntrada;
            int horaSalida;
            Docente do1 = new Docente("Lucas", "Rodriguez", 100, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220);
            Docente do2 = new Docente("Ezquiel", "Oggins", 101, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220);
            Docente do3 = new Docente("Martina", "Lopez", 102, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220);
            Docente do4 = new Docente("Florencia", "Cristeche", 103, true, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 18, 0, 0), 220);

            Console.WriteLine("*****************Lista de Docentes*****************");
            Console.WriteLine(do1.ToString());
            Console.WriteLine(do2.ToString());
            Console.WriteLine(do3.ToString());
            Console.WriteLine(do4.ToString());



            // Alta Pariente
            Console.WriteLine("*****************Lista de Padres*****************");
            Responsable res1 = new Responsable("Sara", "Marquina", 104, true, Eparentezco.Madre, "1550238312");
            Responsable res2 = new Responsable("Mariano", "Prado", 105, false, Eparentezco.Padre, "1550238312");
            Responsable res3 = new Responsable("Daniel", "Palacios", 106, false, Eparentezco.Tío, "1550238312");
            Responsable res4 = new Responsable("Maria", "Marquina", 107, true, Eparentezco.Tía, "1550238312");
            Responsable res5 = new Responsable("Florencia", "Rodriguez", 108, true, Eparentezco.Abuela, "1550238312");

            Console.WriteLine(res1.ToString());
            Console.WriteLine(res2.ToString());
            Console.WriteLine(res3.ToString());
            Console.WriteLine(res4.ToString());
            Console.WriteLine(res5.ToString());

            // Alta administrativo
            Console.WriteLine("*****************Administrativos*****************");
            Administrativo admin = new Administrativo("Luis", "Prado", 150, false, new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 10, 0, 0),ECargo.Secretaria);
            Console.WriteLine(admin.ToString());



            // alta Alumno..

            Console.WriteLine("*****************Lista de Alumnos*****************");
            Alumno al1 = new Alumno("Luis", "Prado", 1000, false, 25000);
            Alumno al2 = new Alumno("Maria", "Prado", 1002, true, 25000);
            Alumno al3 = new Alumno("Laura", "Prado", 1003, true, 25000);
            Alumno al4 = new Alumno("Mateo", "Stigliano", 1004, false, 25000);
            Alumno al5 = new Alumno("Mauricio", "Garcia", 1005, false, 25000);



            Console.WriteLine(al1.ToString());
            Console.WriteLine(al2.ToString());
            Console.WriteLine(al3.ToString());
            Console.WriteLine(al4.ToString());
            Console.WriteLine(al5.ToString());


            // Alta Aula...

            Console.WriteLine("*****************Aula*****************");
            Aula a = new Aula(Ecolor.Amarillo, Eturno.Mañana, do1);

            if (a + al1)
            {
                Console.WriteLine("Se agrego alumno a aula");
            }
            else
            {
                Console.WriteLine("No se agrego alumno a aula");
            }

            if (a + al1)
            {
                Console.WriteLine("Se agrego alumno a aula");
            }
            else
            {
                Console.WriteLine("No se agrego alumno a aula");
            }

            if (a + al2)
            {
                Console.WriteLine("Se agrego alumno a aula");
            }
            else
            {
                Console.WriteLine("No se agrego alumno a aula");
            }
            Console.WriteLine(a.ToString());



















            //PRUEBA DE DATE TIME:

            int h1=9;
            int h2=18;


           DateTime hora1=new DateTime(1,1,1,h1,0,0);
           DateTime hora2=new DateTime(1,1,1,h2,0,0);
          
            

            Console.WriteLine(hora2.Subtract(hora1).Hours);

            Console.WriteLine(hora1.Hour);
            Console.ReadLine();

            

            //int hora1;
            //string hora2;

            //if (ValidarHora(hora1))
            //{

            //}



            //DateTime myDate = DateTime.ParseExact("1200", "HHmm", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime myDate2 = DateTime.ParseExact("1100", "HHmm", System.Globalization.CultureInfo.InvariantCulture);
            //var horas = (myDate - myDate2).TotalHours;


            //Console.WriteLine(horas);
            //Console.ReadLine();


            //yo no me resistí y dí lineas de código
            // DateTime d = new DateTime(01, 01, 01, hora, 00, 00);
            //d.Hour devuelve la hora y con el metodo AddHours se puede restar o sumar
            //por si alguien no lo vió
        }

        public static bool ValidarHora(int hora)
        {
            if(hora >=0 && hora <= 23)
            {
                return true;
            }
            return false;
        }
    }
}
