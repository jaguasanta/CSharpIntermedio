using EnvioCorreoElectronicoApp.Clases;

class Program
{
    static void Main(string[] args)
    {

        string nombre = "Julio Aguasanta";
        int edad = 53;
        string direccion = "Tierra Llana";
        string correoElectronico = "julioagu@hotmail.com";
        string mensaje = "Datos Personales";
        
        Persona julio = new PersonaEjemplo(nombre, edad, direccion, correoElectronico);

        julio.ImprimirDatos();

        CorreoElectronico correo = new CorreoElectronico(correoElectronico, mensaje);

        correo.EnviarCorreoElectronico(correoElectronico, mensaje);
    }
}
