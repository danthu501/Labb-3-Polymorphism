using System;

namespace Labb_3___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirkel C1 = new Cirkel();
            Console.WriteLine("Area Cirkel: "+C1.Area());

            Fyrkant F1 = new Fyrkant();
            Console.WriteLine("Area Fyrkant: "+F1.Area());

            Rektangel R1 = new Rektangel();
            Console.WriteLine("Area Rektangel: "+R1.Area());
        }
    }
}
