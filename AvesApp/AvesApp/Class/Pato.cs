using AvesApp.Interface;

namespace AvesApp.Class
{
    public class Pato : IAve, IAveNadar
    {
        public void Cantar()
        {
            Console.WriteLine("Pato puede cantar");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato puede nadar");
        }

        public void PonerHuevo()
        {
            Console.WriteLine("Pato puede poner huevo");
        }

        public void Volar()
        {
            Console.WriteLine("Pato puede Volar");
        }
    }
}
