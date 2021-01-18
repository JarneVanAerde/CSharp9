using System;

namespace TopLevelCalls
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine($"2 + 2 = {Add(2, 2)}");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
