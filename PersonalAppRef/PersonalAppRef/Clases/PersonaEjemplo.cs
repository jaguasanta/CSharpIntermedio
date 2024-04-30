using System;

namespace PersonalAppRef.Clases
{
    public class PersonaEjemplo : Persona
    {
        public PersonaEjemplo(string Nombre, int Anonacimiento, string Ciudad) : 
            base(Nombre, Anonacimiento, Ciudad)
        {
        }
        public override void MostrarDatos(string Nombre, int AnoNacimiento, string Ciudad)
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Ano Nacimiento: {Anonacimiento}");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }
    }
}
