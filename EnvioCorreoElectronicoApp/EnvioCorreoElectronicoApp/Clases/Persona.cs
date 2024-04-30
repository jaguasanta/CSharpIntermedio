using System;

namespace EnvioCorreoElectronicoApp.Clases
{
    public class Persona
    {

        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo Electronico: {correoElectronico}");
        }

    }
}
