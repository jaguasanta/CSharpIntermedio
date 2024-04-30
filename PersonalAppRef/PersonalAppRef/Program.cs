using PersonalAppRef.Clases;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "Julio Aguasanta";
        int anoNacimiento = 1971;
        string ciudad = "Santo Domingo";

        Persona persona1 = new PersonaEjemplo(nombre, anoNacimiento, ciudad);
        persona1.MostrarDatos(nombre, anoNacimiento, ciudad);

        int edadActual = persona1.ObtenerEdad(anoNacimiento);
        Console.WriteLine($"Edad actual: {edadActual} años");
    }
}