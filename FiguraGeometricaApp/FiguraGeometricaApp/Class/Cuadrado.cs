
using System.Reflection.Metadata.Ecma335;

namespace FiguraGeometricaApp.Class
{
    public class Cuadrado: FiguraGeometrica
    {

        public Cuadrado()
        {
            
        }

        public double CalcularArea()
        {

            return Base *Altura;

        }
        
    }
}
