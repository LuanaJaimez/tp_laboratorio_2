using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Archivos;
using EntidadesAbstractas;
using ClasesInstanciables;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestExcepcionAlumnoRepetido()
        {
            Alumno alumno = new Alumno(1, "Miguel", "Fernandez", "12345678", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno1 = new Alumno(1, "Cristian", "Jaimez", "35804304", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Universidad universidad = new Universidad();
            universidad += alumno;
            universidad += alumno1;

            Assert.AreEqual(alumno, alumno1);
        }


        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestExcepcionDniInvalido()
        {
            Alumno alumno = new Alumno(2, "Marcelo", "Espinoza", "ghj834", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }


        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestExcepcionNacionalidadInvalida()
        {
            Alumno alumno = new Alumno(1, "Miguel", "Fernandez", "900000000", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }


        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestExcepcionSinProfesor()
        {
            Universidad universidad = new Universidad();
            universidad += Universidad.EClases.Laboratorio;
        }


        [TestMethod]
        public void TestValidaAtributoNull()
        {
            Universidad universidad = new Universidad();

            Assert.IsNotNull(universidad.Alumnos);
        }

        [TestMethod]
        public void TestAtributoNumerico()
        {
            int valor = 35804304;
            Alumno alumno = new Alumno(1, "Lucio", "Atienza", "35804304", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Assert.AreEqual(valor, alumno.DNI);
        }

        public void TestColeccionAlumnos()
        {
            Universidad universidad = new Universidad();

            Assert.IsNotNull(universidad.Alumnos);
        }
    }
}
