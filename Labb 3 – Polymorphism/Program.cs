using System;

namespace Labb_3___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckning C1 = new Cirkel();
            Console.WriteLine("Area Cirkel: "+C1.Area());

            Teckning F1 = new Fyrkant();
            Console.WriteLine("Area Fyrkant: "+F1.Area());

            Teckning R1 = new Rektangel();
            Console.WriteLine("Area Rektangel: "+R1.Area());
        }
    }
}
