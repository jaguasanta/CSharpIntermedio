using FiguraGeometricaCApp.Class;

class Program
{
    static void Main(string[] args)
    {

        double base1 = 5;
        double Altura1 = 4;
        double lado1 = 4;

        Rectangulo rectangulo = new Rectangulo ( base1, Altura1 );
        Cuadrado cuadrado = new Cuadrado ( lado1 );

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}"); 

        Console.ReadKey();
    }
}

