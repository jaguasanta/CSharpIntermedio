namespace EnvioCorreoElectronicoApp.Clases
{
    public class PersonaEjemplo: Persona
    {
        public PersonaEjemplo(string nombre, int edad, string direccion, string correoElectronico)
        {

            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correElectronico = correoElectronico;

        }

        public override void ImprimirDatos()
        {
            Console.WriteLine("Nombre: " +  this.nombre);
            Console.WriteLine("Edad: " + this.edad);
            Console.WriteLine("Direccion: " + this.direccion);
            Console.WriteLine("Correo Electronico: " + this.correElectronico);
        }
    }
}
