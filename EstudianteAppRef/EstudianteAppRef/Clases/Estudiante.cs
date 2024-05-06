namespace EstudianteAppRef.Clases
{
    public class Estudiante : Persona
    {

        public string Carrera { get; set; }
        public string Matricula { get; set; }
                
        public Estudiante(string carrera, string matricula)
        {
            Carrera = carrera;
            Matricula = matricula;
        }
        public override void MostrarDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Ano Nacimiento: {persona.Anonacimiento}");
            Console.WriteLine($"Ciudad: {persona.Ciudad}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matrícula: {Matricula}");

        }
    }
}
