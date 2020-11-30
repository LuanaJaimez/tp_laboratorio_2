using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using FormPrincipal;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [ExpectedException(typeof(BolsaLlenaException))]
        public void TestExcepcionAlumnoRepetido()
        {
            Bolsa<Prenda> bolsa = 3;
            Prenda p1 = new Prenda(1, Prenda.ETipoPrenda.Remera, "Nike", 1345, 7);
            Prenda p2 = new Prenda(1, Prenda.ETipoPrenda.Zapato, "Adidas", 8434, 1);
            Prenda p3 = new Prenda(1, Prenda.ETipoPrenda.Pantalon, "Puma", 3928, 8);
            Prenda p4 = new Prenda(1, Prenda.ETipoPrenda.Zapato, "Zara", 7340, 6);
            Prenda p5 = new Prenda(1, Prenda.ETipoPrenda.Remera, "Nike", 1923, 4);

            bolsa += p1;
            bolsa += p2;
            bolsa += p3;
            bolsa += p4;
            bolsa += p5;
        }

        [TestMethod]
        public void TestTipoPrendaNull()
        {
            Prenda produc = new Prenda();

            Assert.IsNotNull(produc.tipo);
        }

        [TestMethod]
        public void TestPrecioNull()
        {
            Accesorio produc = new Accesorio();
            int precio = 0;

            Assert.AreEqual(produc.precio, precio);
        }



    }
}
