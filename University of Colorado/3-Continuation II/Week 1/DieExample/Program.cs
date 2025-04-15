using System;

namespace DieExample
{
    /// <summary>
    /// Demonstrates testing the Die class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Tests the Die class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // test standard die
            Die standardDie = new Die();
            Console.WriteLine("Standard Die");
            Console.WriteLine("------------");
            Console.WriteLine("Number of Sides: " + standardDie.NumSides);
            Console.WriteLine("Top Side: " + standardDie.TopSide);
            Console.WriteLine();

            // roll the die
            standardDie.Roll();
            Console.WriteLine("Top Side: " + standardDie.TopSide);
            Console.WriteLine();

            // roll the die
            standardDie.Roll();
            Console.WriteLine("Top Side: " + standardDie.TopSide);
            Console.WriteLine();

            // roll the die
            standardDie.Roll();
            Console.WriteLine("Top Side: " + standardDie.TopSide);
            Console.WriteLine();

            // test D20 die
            Die d20Die = new Die(20);
            Console.WriteLine("D20 Die");
            Console.WriteLine("-------");
            Console.WriteLine("Number of Sides: " + d20Die.NumSides);
            Console.WriteLine("Top Side: " + d20Die.TopSide);
            Console.WriteLine();

            // roll the die
            d20Die.Roll();
            Console.WriteLine("Top Side: " + d20Die.TopSide);
            Console.WriteLine();

            // roll the die
            d20Die.Roll();
            Console.WriteLine("Top Side: " + d20Die.TopSide);
            Console.WriteLine();

            // roll the die
            d20Die.Roll();
            Console.WriteLine("Top Side: " + d20Die.TopSide);
            Console.WriteLine();
        }
    }
}
