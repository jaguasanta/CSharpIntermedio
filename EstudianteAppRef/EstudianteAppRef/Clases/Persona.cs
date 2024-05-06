namespace EstudianteAppRef.Clases
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Anonacimiento { get; set; }
        public string Ciudad { get; set; }

        public abstract void MostrarDatos(Persona persona);

        public int ObtenerEdad(int anoNacimiento)
        {
            int anoActual = DateTime.Now.Year;
            return anoActual - Anonacimiento;
        }

    }
}
