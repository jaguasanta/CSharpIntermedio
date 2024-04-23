using System;

namespace PersonaApp
{
    public class Persona
    {

        // Atributos de la clase
        public string nombre;
        public int anioNacimiento;
        public string ciudad;

        public Persona()
        {

        }

        public Persona(string nombre, int anioNacimiento, string ciudad)
        {
            this.nombre = nombre;
            this.anioNacimiento = anioNacimiento;
            this.ciudad = ciudad;
        }

        public void MostrarDatos(string nombre, int anioNacimiento,  string ciudad) 
        {

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Año Nacimiento:" + anioNacimiento);
            Console.WriteLine("Ciudad:" + ciudad);
            
        }

        public int ObtenerEdad(int anioNacimiento) 
        {
            int anioActual = DateTime.Now.Year;
            return anioActual - anioNacimiento;

        }

    }
}
