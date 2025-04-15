namespace EX1
{
    internal class Program
    {
        /// <summary>
        /// Integer Data Types Lecture Code
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed=100;
            const int SecondsPerMinute = 60;

            //calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed/SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed%SecondsPerMinute; 

            //print minutes and seconds played
            Console.WriteLine("Minutes Played: " + minutesPlayed);
            Console.WriteLine("Seconds Played: " +  secondsPlayed);

            Console.WriteLine("You Played " + minutesPlayed + " minutes and " + secondsPlayed + " seconds");
        }
    }
}
