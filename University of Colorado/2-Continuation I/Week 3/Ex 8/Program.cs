namespace Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please select max number (1-10): ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<=n;i++) {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write("Please select number of * : ");
            int a = int.Parse(Console.ReadLine());

            for (int j = 0; j < a; j++)
            {
                    Console.Write("*");
                
            }
        }
    }
}
