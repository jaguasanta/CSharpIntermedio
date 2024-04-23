using System.Diagnostics;
using CalculoAreaAPP;

class Program
{
    static void Main(string[] args)
    {

        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };
        Circulo circulo = new Circulo { Radio = 3 };
        Triangulo triangulo = new Triangulo { Base = 8, Altura = 6 };

        Console.WriteLine("Area del Rectangulo : " + rectangulo.CalculoArea());
        Console.WriteLine("Area del Circulo : " + circulo.CalculoArea());
        Console.WriteLine("Area del Trinagulo :" + triangulo.CalculoArea());

    }
}
