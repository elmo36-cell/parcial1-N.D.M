using DemoBiblioteca;

namespace DemoPruebaUnitaria;

[TestClass]
public sealed class TestUnitCirculo
{
    [TestMethod]
    public void TestAreaCirculo()
    {
        var circulo = new Circulo { Radio = 3.0 };
        double resultado = circulo.Area();
        Assert.AreEqual(28.274333882308138, resultado);
    }
    [TestMethod]
    public void TestPerimetroCirculo()
    {
        var circulo = new Circulo { Radio = 3.0 };
        double resultado = circulo.Perimetro();
        Assert.AreEqual(18.84955592153876, resultado);
    }
}
