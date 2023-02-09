using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL_Csharp.GeometryExample
{
    public class Cylinder: Icrylinder
    {
        public Cylinder() { }

        private double radius;
        private double height;
        private double basearea;
        private double latearea;
        private double totalarea;
        private double volume;
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Base Area: " + baseArea);
            Console.WriteLine("Lateral Area: " + lateralArea);
            Console.WriteLine("Total Area: " + totalArea);
            Console.WriteLine("Volume: " + volume);
        }
    }

}