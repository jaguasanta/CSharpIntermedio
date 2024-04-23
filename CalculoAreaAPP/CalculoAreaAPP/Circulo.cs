using System;

namespace CalculoAreaAPP
{
    public class Circulo: Figura
    {
        public double Radio { get; set; }

        public override double CalculoArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
