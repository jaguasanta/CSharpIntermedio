using System;

namespace EnvioCorreoElectronicoApp.Clases
{
    public class CorreoElectronico
    {
        public string correoElectronico { get; set; }

        public string mensaje { get; set; }
        public CorreoElectronico(string correoElectronico, string mensaje)
        {
            
            this.correoElectronico = correoElectronico;
            this.mensaje = mensaje;

        }
        public void EnviarCorreoElectronico(string correoElectronico, string mensaje)
        {
            Console.WriteLine("Correo Electronico: " + this.correoElectronico + " Mensaje Enviado: " + this.mensaje);
        }

    }
}
