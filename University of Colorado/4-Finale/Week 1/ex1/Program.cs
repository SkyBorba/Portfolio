namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insert Whole Number: ");
                int input = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Thats not a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Thats not in range");
            }
            finally
            {
                Console.WriteLine("finished");
            }
        }
    }
}
