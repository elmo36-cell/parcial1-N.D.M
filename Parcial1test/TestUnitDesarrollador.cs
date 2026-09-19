namespace Parcial1test
{
    [TestClass]
    public sealed class TestUnitDesarrollador
    {
        [TestMethod]
        public void TestDesarrollador1()
        {
            var desarrollador = new Parcial1lib.Empleado.Desarrollador("Juan", 1000, 200);
            var salarioTotal = desarrollador.CalcularSalario();
            Assert.AreEqual(1200, salarioTotal);
        }  
    }
}
