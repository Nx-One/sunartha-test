using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 500; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(" tik");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" tek");
                }
                else if (i%7 == 0)
                {
                    Console.Write(" tok");
                }
                else
                {
                    Console.Write($" {i}");
                }
            }
        }
    }
}
