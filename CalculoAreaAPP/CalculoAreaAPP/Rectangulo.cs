using System;

namespace CalculoAreaAPP
{
    public class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }  
        public override double CalculoArea()
        {
            return Base * Altura;
        }
    }
}
