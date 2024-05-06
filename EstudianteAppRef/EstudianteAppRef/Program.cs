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

        Persona julio = new PersonaEjemplo(nombre, anoNacimiento, ciudad);
        Estudiante julio1 = new Estudiante(carrera, matricula);

        julio1.MostrarDatos(julio);

        Console.WriteLine("Edad de " + julio.Nombre + ": " + julio.ObtenerEdad(anoNacimiento) + " años");

    }
}
