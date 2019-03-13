using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredRandoms
{
    class RandomGenerator
    {
        Random random = new Random();
        public List<int> randomNumberList = new List<int>();
        public List<int> squaredNumbers = new List<int>();

        public void RandomNumbers()
        {
            var numberString = "";
            var randomNumberString = "";
            var evenNumbersString = "";
            for (var i = 0; i < 20; i++)
            {
                var randomVariable = (random.Next(1, 50));
                randomNumberList.Add(randomVariable);
            }
            foreach (var number in randomNumberList)
            {
                numberString += number + ",";
            }
            foreach (var number in randomNumberList)
            {
                var squared = number * number;
                squaredNumbers.Add(squared);
                randomNumberString += squared + ",";
            }
            foreach (var squaredNumber in squaredNumbers)
            {
                if (squaredNumber % 2 == 0)
                {
                    evenNumbersString += squaredNumber + ",";

       
                }
            }
            Console.WriteLine($"{numberString.TrimEnd(',')}");
            Console.WriteLine($"{randomNumberString.TrimEnd(',')}");
            Console.WriteLine($"{evenNumbersString.TrimEnd(',')}");
        }
    }
}
