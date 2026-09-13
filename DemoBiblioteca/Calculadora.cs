using System.Net.Sockets;

namespace DemoBiblioteca
{
    public abstract class Figura
    {
        public abstract double Area();
        public abstract double Perimetro();
    }
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }
        public override double Area()=> Lado * Lado;
        public override double Perimetro() => Lado * 4;
    }

    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double Area() => Base * Altura;
        public override double Perimetro() => 2 * (Base + Altura);
    }
}
