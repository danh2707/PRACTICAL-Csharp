using PRACTICAL_Csharp.exe2;
using PRACTICAL_Csharp.GeometryExample;
using System;

namespace GeometryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //exe1
            Console.WriteLine("Enter radius of cylinder:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of cylinder:");
            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();
            Console.WriteLine("Cylinder Result:");
            cylinder.Result();

            //exe2
            Home a = new Lion(250, "Lion");
            a.Show();
            a = new Tiger(200, "Tiger");
            a.Show();

        }
    }
}