using System.Diagnostics;
using EstudianteAPP;

class Program
{
    static void Main(string[] args)
    {

        string nombre = "Julio Aguasanta";
        int anioNacimiento = 1971;
        string ciudad = "Santo Domingo";
        string carrera = "Ingenieria de Sistemas";
        string matricula = "87-0185";

        Estudiante julio = new Estudiante(nombre, anioNacimiento, ciudad, carrera, matricula);

        julio.MostrarEstudiante(nombre, anioNacimiento, ciudad, carrera, matricula);

        Console.WriteLine("Edadd de " + julio.nombre + ": " + julio.ObtenerEdad(anioNacimiento) + " años");

    }
}
