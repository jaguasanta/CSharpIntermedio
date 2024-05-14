using FiguraGeometricaApp.Class;

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 3 };
        Cuadrado cuadrado = new Cuadrado { Base = 6, Altura = 5 };

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");

        Console.ReadKey();
    }
}
