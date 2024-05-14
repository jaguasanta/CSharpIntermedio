namespace FiguraGeometricaCApp.Class
{
    public class Cuadrado: FiguraGeometrica
    {
        public double lado { get; set; }

        public Cuadrado(double lado)
        {
            this.lado = lado;

        }

        public override double CalcularArea()
        {
            return lado * lado ;
        }
    }
}
