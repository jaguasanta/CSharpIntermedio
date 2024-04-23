using System.Diagnostics;
using PersonaApp;

class Program
{

    static void Main(string[] args)
    {

        string nombre = "Julio Aguasanta";
        int anioNacimiento = 1971;
        string ciudad = "Santo Domingo";
                      
        Persona julio = new Persona(nombre, anioNacimiento, ciudad);

        julio.MostrarDatos(nombre, anioNacimiento, ciudad);

        Console.WriteLine("Edad de " + julio.nombre + ": " + julio.ObtenerEdad(anioNacimiento) + " años");

    }
}