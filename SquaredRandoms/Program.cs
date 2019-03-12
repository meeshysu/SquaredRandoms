using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumberList = new List<int>();
            Random random = new Random();

            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(random.Next(1, 50));
            }

            Console.ReadLine();
        }
    }
}
