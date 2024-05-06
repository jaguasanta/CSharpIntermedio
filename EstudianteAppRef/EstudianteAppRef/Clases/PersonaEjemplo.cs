namespace EstudianteAppRef.Clases
{
    public class PersonaEjemplo : Persona
    {

        public PersonaEjemplo(string nombre, int anoNacimiento, string ciudad)
        { 

            this.Nombre = nombre;
            this.Anonacimiento = anoNacimiento;
            this.Ciudad = ciudad;

        }

        public override void MostrarDatos(Persona persona)
        {
            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Año Nacimiento: " + persona.Anonacimiento);
            Console.WriteLine("Ciudad: " + persona.Ciudad);

        }
    }
}
