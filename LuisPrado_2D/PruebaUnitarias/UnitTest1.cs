using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JardinInfantes_Biblioteca;
using FrmJardinInfantes;

namespace PruebaUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarAlumno()
        {
            ///Arange
            Responsable res = new Responsable("Pepe", "Juarez", 39207451, false, Eparentezco.Padre, "43022874");
            Alumno alumno1 = new Alumno("Lucas", "Martinez", 39207770, false, 25000, res);
            //Act
            //asert
            Assert.IsNotNull(alumno1);// verofica que no sea null y da ok por que el alumno es instanciado.


        }
        [TestMethod]
        [ExpectedException(typeof(PersonaSinDNIException))]//espera una excepcion de persona sin dni
        public void PersonaSinDni()
        {
            ///Arange
            Responsable res = new Responsable("Pepe", "Juarez", 39207451, false, Eparentezco.Padre, "43022874");
            Alumno alumno2 = new Alumno("Juan", "Martinez", 0, false, 25000, res);
            //Act


        }

        [TestMethod]
        public void CrearDocentesAlumnosTest()
        {
            FrmAula menu = new FrmAula();

            //al cargar 8 docentes en el constructor y son 74 alumnos sin aula pero al cargarse en el metodo cargar alumnos a aula se eliminan los de sin aula.
            Assert.IsTrue(menu.docentes.Count == 8 && menu.alumnosSinAula.Count == 54);
        }
    }
}
