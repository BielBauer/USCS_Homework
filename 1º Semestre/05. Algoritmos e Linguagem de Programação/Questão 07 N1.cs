{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2000;

            while (x < 9000)
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                    x++;
                }
                else
                    x++;
            Console.ReadKey();              
        }
    }
}
