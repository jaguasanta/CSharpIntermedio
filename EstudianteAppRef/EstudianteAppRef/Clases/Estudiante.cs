using System;
using System.Diagnostics.Contracts;

namespace EstudianteAppRef.Clases
{
    public class Estudiante : Persona
    {

        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante(string nombre, int anoNacimiento, string ciudad, string carrera, string matricula)
        : base(nombre, anoNacimiento, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }
        public override void MostrarDatos(string Nombre, int AnoNacimiento, string Ciudad)
        {

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Ano Nacimiento: {AnoNacimiento}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matrícula: {Matricula}");

        }
    }
}
