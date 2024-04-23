using System;
using System.Xml.Serialization;

namespace EstudianteAPP
{
    public class Estudiante: Persona
    {

        // Atributos especificos del estudiante

        public string carrera;
        public string matricula;

        public Estudiante(string nombre, int anioNacimiento, string ciudad, string carrera, string matricula)
            : base(nombre, anioNacimiento, ciudad)
        {
            this.carrera = carrera;
            this.matricula = matricula; 
                
        }
        public void MostrarEstudiante(string nombre, int anioNacimiento, string ciudad, string carrera, string matricula)
        {
            MostrarDatos(nombre, anioNacimiento, ciudad);
            Console.WriteLine("Carrera: " + carrera);
            Console.WriteLine("Matricula: " + matricula);
        }

    }
}
