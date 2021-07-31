using System;

namespace TaskThree
{
    public class Cone
    {
        private readonly double _radius;
        private readonly double _height;
        public Cone (double radius, double height)
        {
            _radius = radius;
            _height = height;
        }
        public double TheSurfaceAreaOfTheConeBase()
        {
            double baseArea = Math.PI * (Math.Pow(_radius, 2));
            return baseArea;
        }
        public double TheAreaOfTheFullSurfaceOfTheCone()
        {
            double totalSurfaceArea = Math.PI * _radius * (_radius + Math.Sqrt(Math.Pow(_radius, 2) + Math.Pow(_height, 2)));
            return totalSurfaceArea;
        }
    }
}
