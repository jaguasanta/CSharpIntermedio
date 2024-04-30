using EstudianteAppRef.Clases;

class Program
{
    static void Main(string[] args)
    {

        string nombre = "Julio Aguasanta";
        int anoNacimiento = 1971;
        string ciudad = "Santo Domingo";
        string carrera = "Ingenieria de Sistemas";
        string matricula = "87-0185";

        Estudiante julio = new Estudiante(nombre, anoNacimiento, ciudad, carrera, matricula);

        julio.MostrarDatos(nombre, anoNacimiento,ciudad);

        Console.WriteLine("Edadd de " + julio.Nombre + ": " + julio.ObtenerEdad(anoNacimiento) + " años");

    }
}
