/*
 * @autor: Some smart guy on internet
 * @date: 05/15/2015
 * @project: String Combination
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// An algorithm is said to be naive when it is simple and straightforward but does not exhibit a desirable level of efficiency (usually in terms of time, but also possibly memory) 
    /// despite finding a correct solution or it does not find an optimal solution to an optimization problem, and better algorithms can be designed and implemented with more careful 
    /// thought and clever techniques. Naive algorithms are easy to discover, often easy to prove correct, and often immediately obvious to the problem solver. They are often based on 
    /// simple simulation or on brute force generation of candidate solutions with little or no attempt at optimization. Despite their inefficiency, naive algorithms are often the stepping
    /// stone to more efficient, perhaps even asymptotically optimal algorithms, especially when their efficiency can be improved by choosing more appropriate data structures.
    /// </summary>
    /// <seealso cref="https://en.wikipedia.org/wiki/String_searching_algorithm"/>
    public class NaivePatternSearching
    {
        /// <summary>
        /// Given a text input[0..n-1] and a pattern pattern[0..m-1], write a function Search(string input, string pattern)that prints all occurrences of pattern[] in input[]. You may 
        /// assume that n > m.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="pattern">The pattern to search</param>
        /// <returns>The index where the pattern starts</returns>
        /// <see cref="http://www.personal.kent.edu/~rmuhamma/Algorithms/MyAlgorithms/StringMatch/naiveStringMatch.htm"/>
        /// <seealso cref="http://www.geeksforgeeks.org/searching-for-patterns-set-1-naive-pattern-searching/"/>
        /// <example> input[] =  "THIS IS A TEST TEXT", pattern[] = "TEST", output:10</example>
        public static int Search(string input, string pattern)
        {
            int inputLength = input.Length;
            int patternLength = pattern.Length;

            for (int i = 0; i <= inputLength-patternLength; i++)
            {
                for (int j = 0; j < patternLength; j++)
                {
                    if (input[i + j] != pattern[j])
                        break;

                    if (j == patternLength-1)
                        return i;
                }
            }

            return -1;
        }
    }
}
