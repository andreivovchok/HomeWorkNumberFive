using System;
using TaskThree;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            Cone cone = new Cone(8, 6);
            Console.WriteLine($"Площадь основания = {cone.TheSurfaceAreaOfTheConeBase()}");
            Console.WriteLine($"Полная площадь = {cone.TheAreaOfTheFullSurfaceOfTheCone()}");

            
            


            
        }
    }
}
