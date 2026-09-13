using DemoBiblioteca;

namespace DemoPruebaUnitaria
{
    [TestClass]
    public sealed class TestUnitRectangulo
    {
        [TestMethod]
        public void TestAreaRectangulo()
        {
            var rectangulo = new Rectangulo { Base = 5.0, Altura = 3.0 };
            double resultado = rectangulo.Area();
            Assert.AreEqual(15.0, resultado);
        }
        [TestMethod]
        public void TestPerimetroRectangulo()
        {
            var rectangulo = new Rectangulo { Base = 4.0, Altura = 5.0 };
            double resultado = rectangulo.Perimetro();
            Assert.AreEqual(18.0, resultado);
        }
    }
}
