using System.Diagnostics;
using System.Linq;

namespace com.hack3rlife.numbers
{
    /// <summary>
    /// A prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself. A natural number greater than 
    /// 1 that is not a prime number is called a composite number.
    /// </summary>
    /// <example>5 is prime because 1 and 5 are its only positive integer factors, whereas 6 is composite because it has the divisors 2 and 3 in addition to
    /// 1 and 6.</example>
    /// <see cref="https://en.wikipedia.org/wiki/Prime_number"/>
    public class PrimeNumbers
    {
        /// <summary>
        /// Given a positive integer, check if the number is prime or not. A prime is a natural number greater than 1 that has no positive divisors other than 1 and itself.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if the number is prime; otherwise false</returns>
        /// <remarks>Checks if a number is prime or not using Prmality Test</remarks>
        /// <see cref="http://en.wikipedia.org/wiki/Primality_test"/>
        /// <seealso cref="http://www.geeksforgeeks.org/primality-test-set-1-introduction-and-school-method/"/>
        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
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

                    Debug.WriteLine(string.Format(" {0},{1}", j, 1));

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
