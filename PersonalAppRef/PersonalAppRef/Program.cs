using PersonalAppRef.Clases;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "Julio Aguasanta";
        int anoNacimiento = 1971;
        string ciudad = "Santo Domingo";

        Persona julio = new PersonaEjemplo(nombre, anoNacimiento, ciudad);
        julio.MostrarDatos(nombre, anoNacimiento, ciudad);
                
        int edadActual = julio.ObtenerEdad(anoNacimiento);
        Console.WriteLine($"Edad actual: {edadActual} años");
    }
}