using System;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = new object[20];
            Random random = new Random();

            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(random.Next(1, 50));
            }

            Console.ReadLine();
        }
    }
}
