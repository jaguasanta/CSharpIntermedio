using System;
using AvesApp.Interface;

namespace AvesApp.Class
{
    public class Aguila : IAve, IAveCazar
    {
        public void Cantar()
        {
            Console.WriteLine("Aguila puede cantar");
        }

        public void Cazar()
        {
            Console.WriteLine("Aguila puede cazar");           
        }

        public void PonerHuevo()
        {
            Console.WriteLine("Aguila puede Poner Huevo");
        }

        public void Volar()
        {
            Console.WriteLine("Aguila puede Volar");
        }
    }
}
