using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.Controllers
{
    public class NumbersController
    {
        public string RemovePrimeNumbers(string numbers)
        {
            var separated = numbers.Split(new char[] { ',' });
            List<int> parsedNumbers = separated.Select(s => int.Parse(s)).ToList();

            List<int> correctNumbers = new List<int>();
            foreach (int number in parsedNumbers)
            {
                if (!IsPrimeNumber(number))
                {
                    correctNumbers.Add(number);
                }
            }

            correctNumbers.Sort();
            correctNumbers.Reverse();

            return string.Join(",", correctNumbers);
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number == 1) return false;

            double dividedByTwo = (double)number / 2;
            double divideByThree = (double)number / 3;

            if (dividedByTwo == 1 || divideByThree == 1)
            {
                return true;
            }

            if (dividedByTwo == (int)dividedByTwo || divideByThree == (int)divideByThree)
            {
                return false;
            }

            return true;
        }
    }
}
