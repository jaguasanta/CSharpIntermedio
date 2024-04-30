using System;

namespace EstudianteAppRef.Clases
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Anonacimiento { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombre, int anonacimiento, string ciudad)
        {
            this.Nombre = nombre;
            this.Anonacimiento = anonacimiento;
            this.Ciudad = ciudad;
        }

        public abstract void MostrarDatos(string Nombre, int AnoNacimiento, string Ciudad);

        public int ObtenerEdad(int anoNacimiento)
        {
            int anoActual = DateTime.Now.Year;
            return anoActual - Anonacimiento;
        }

    }
}
