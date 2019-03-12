using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredRandoms
{
    class RandomGenerator
    {
        Random random = new Random();
        public List<int> randomNumberList = new List<int>();


        public void randomNumbers()
        {
            var emptyString = "";
            for (var i = 0; i < 20; i++)
            {
                var randomVariable = (random.Next(1, 50));
                randomNumberList.Add(randomVariable);
            }
            foreach (var number in randomNumberList)
            {
                Console.Write($"{number},");
            }
            foreach (var number in randomNumberList)
            {
                var squaredNumber = number * number;
                emptyString += squaredNumber.ToString();

                Console.Write($"{squaredNumber}, ");
            }
        }
    }
}
