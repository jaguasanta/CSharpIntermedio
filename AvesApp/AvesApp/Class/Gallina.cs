using AvesApp.Interface;

namespace AvesApp.Class
{
    public class Gallina : IAve
    {
        public void Cantar()
        {
            Console.WriteLine("Gallina puede cantar");
        }

        public void PonerHuevo()
        {
            Console.WriteLine("Gallina puede Poner Huevo");
        }

        public void Volar()
        {
            Console.WriteLine("Gallina puede volar");
        }
    }
}
