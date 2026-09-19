namespace Parcial1lib
{
    public abstract class Empleado(string nombre, double salarioBase)
    {
        public string Nombre { get; set; } = nombre;
        public double SalarioBase { get; set; } = salarioBase;
        public abstract double CalcularSalario();

        public class obtenerInformacion()
        {
            public string ObtenerInformacion(Empleado empleado)
            {
                return $"Nombre: {empleado.Nombre}, Salario Base: {empleado.SalarioBase}, Salario Total: {empleado.CalcularSalario()}";
            }
        }
        public class calcularSalarioTotal()
        {
            public double CalcularSalarioTotal(Empleado empleado)
            {
                return empleado.CalcularSalario();
            }
        }
        public class Desarrollador(string nombre, double salarioBase, double bonoProductividad) : Empleado(nombre, salarioBase)
        {
            public double BonoProductividad { get; set; } = bonoProductividad;
            public override double CalcularSalario()
            {
                return SalarioBase + BonoProductividad;
            }
        }
        public class Gerente(string nombre, double salarioBase, double comision) : Empleado(nombre, salarioBase)
        {
            public double Comision { get; set; } = comision;
            public override double CalcularSalario()
            {
                return SalarioBase + Comision;
            }
        }

    } 
}
