using System;
using System.Drawing;
namespace milibreria
{
    class avion
    {
        public string color;
        public string marca;
        public int matricula;
        public int capacidad;


        
        public void Volar()
        {
            Console.WriteLine("volando");
        }
        public void aterizar()
        {
            Console.WriteLine("aterizando");
        }
        public void despegar()
        {
            Console.WriteLine("despegando");
        }
    }
}
