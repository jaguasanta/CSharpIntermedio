namespace EnvioCorreoElectronicoApp.Clases
{
    public abstract class Persona
    {

        public string nombre { get; set; }

        public int edad { get; set; }

        public string direccion { get; set; }

        public string correElectronico { get; set; }

        public abstract void ImprimirDatos();

    }
}
