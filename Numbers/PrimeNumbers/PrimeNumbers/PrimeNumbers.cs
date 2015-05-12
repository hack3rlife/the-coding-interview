using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.numbers
{
    public class PrimeNumbers
    {
        /// <summary>
        /// Checks if a number is prime or not using Prmality Test
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if the number is prime; otherwise false</returns>
        /// <see cref="http://en.wikipedia.org/wiki/Primality_test"/>
        public static bool isPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else if (number <= 3)
            {
                return true;
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            int i = 5;

            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }

                i += 6;
            }

            return true;
        }

        /// <summary>
        /// Prints all primes number smaller than or equal to number
        /// </summary>
        /// <param name="number"></param>
        /// <see cref=">http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes"/>
        public static void SieveOfEratosthenes(int number)
        {
            bool[] arr = Enumerable.Repeat(true, number).ToArray();

            for (int i = 1; i < number; i++)
            {
                if (arr[i] == true)
                {
                    int j = i + 1;

                    Console.Write(" {0} ", j);

                    int k = 2;
                    int num;

                    while ((num = j * k) <= number)
                    {
                        arr[num - 1] = false;
                        k++;
                    }
                }
            }           
        }

    }
}
