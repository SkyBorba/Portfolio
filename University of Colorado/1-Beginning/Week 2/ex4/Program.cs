namespace ex4
{
    /// <summary>
    /// Floating Point Data Types
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrate floating point data types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int score = 1360;
            int totalSecondsPlayed = 1000;

            //Calculate and print points per second

            float pointsPerSecond=(float)score/totalSecondsPlayed;
            Console.WriteLine("Points per second: " + pointsPerSecond);
        }
    }
}
