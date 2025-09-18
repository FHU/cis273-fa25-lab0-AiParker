using System;

namespace Vector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vector v1 = new Vector { X = 3, Y = 4 };
            Vector v2 = new Vector { X = -2, Y = 5 };

            Vector sum = v1 + v2;
            Vector diff = v1 - v2;
            double dot = v1 * v2;
            Vector scaled = v1 * 2;
            Vector normalized = v1.Normalize();
            double angle = v1.AngleBetween(v2);

            Console.WriteLine($"v1 = {v1}");
            Console.WriteLine($"v2 = {v2}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Difference = {diff}");
            Console.WriteLine($"Dot Product = {dot}");
            Console.WriteLine($"Scaled v1 = {scaled}");
            Console.WriteLine($"Normalized v1 = {normalized}");
            Console.WriteLine($"Angle between v1 and v2 = {angle} degrees");
            Console.WriteLine($"v1 Magnitude = {v1.Magnitude}");
            Console.WriteLine($"v1 Direction = {v1.Direction} degrees");
        }
    }
}
