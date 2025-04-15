using System;

namespace EX6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number degree: ");
            float degree = float.Parse(Console.ReadLine());

            degree = degree * (float)Math.PI / 180;

            Console.WriteLine("Consine: " + Math.Cos(degree));
            Console.WriteLine("Sine: " + Math.Sin(degree));
        }
    }
}
