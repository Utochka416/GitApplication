using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
        public void MatrixB(int length, int width)
        {
            Random random = new Random();
            random.Next(0, 2);
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    Console.WriteLine(random);
                    random.Next(0,2);
                }
            }
        }   
    }
}
