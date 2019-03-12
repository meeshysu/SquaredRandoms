using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfRandomness = new RandomGenerator();
            numberOfRandomness.randomNumbers();

            Console.ReadLine();
        }
    }
}
