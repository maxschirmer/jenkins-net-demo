using System;

namespace Demo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello Jenkins!");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}