namespace FiguraGeometricaCApp.Class
{
    public class Rectangulo : FiguraGeometrica
    {

        public double Base { get; set; }

        public double Altura { get; set; }

        public Rectangulo( double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;   
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
