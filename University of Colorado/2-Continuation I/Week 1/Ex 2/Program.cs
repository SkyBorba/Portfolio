namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");

            Console.WriteLine("Please pick you option");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: Console.WriteLine("Starting New Game...");
                    break;

                case 2: Console.WriteLine("Loading Game...");
                    break;

                case 3:
                    Console.WriteLine("Loading Options");
                    break;

                case 4:
                    Console.WriteLine("Closing Program...");
                    break;

                default: Console.WriteLine("Invalide Choice!!");
                    break;
            }




        }
    }
}
