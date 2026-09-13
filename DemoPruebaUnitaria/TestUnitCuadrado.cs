using DemoBiblioteca;

namespace DemoPruebaUnitaria
{
    [TestClass]
    public sealed class TestUnitCuadrado
    {
        [TestMethod]
        public void TestAreaCuadrado()
        {
            var cuadrado = new Cuadrado { Lado = 5.0 };
            double resultado = cuadrado.Area();
            Assert.AreEqual(25.0, resultado);
        }
        [TestMethod]
        public void TestPerimetroCuadrado()
        {
            var cuadrado = new Cuadrado { Lado = 4.0 };
            double resultado = cuadrado.Perimetro();
            Assert.AreEqual(16.0, resultado);
        }
    }
}
