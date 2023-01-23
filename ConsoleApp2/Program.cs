using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void MatrixA(int len, int wid)
        {
            Random num = new Random();
            num.Next(0, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < wid; i++)
            {
                for (int x = 0; x < len; x++)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
