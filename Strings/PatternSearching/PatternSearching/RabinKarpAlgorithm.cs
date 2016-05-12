/*
 * @autor: Some smart guy on internet
 * @date: 04/22/2015
 * @project: String Combination
 * 
 */

namespace com.hack3rlife.strings
{
    /// <summary>
    /// In computer science, the Rabin–Karp algorithm or Karp–Rabin algorithm is a string searching algorithm created by Richard M. Karp and Michael O. Rabin (1987) that uses hashing to 
    /// find any one of a set of pattern strings in a text. For text of length n and p patterns of combined length m, its average and best case running time is O(n+m) in space O(p), but
    /// its worst-case time is O(nm). In contrast, the Aho–Corasick string matching algorithm has asymptotic worst-time complexity O(n+m) in space O(m).  
    /// 
    /// A practical application of the algorithm is detecting plagiarism.  Given source material, the algorithm can rapidly search through a paper for instances of sentences from the source
    /// material, ignoring details such as case and punctuation. Because of the abundance of the sought strings, single-string searching algorithms are impractical.
    /// 
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Rabin%E2%80%93Karp_algorithm"/>
    public class RabinKarpAlgorithm
    {
        /// <summary>
        /// Given a text input[0..n-1] and a pattern pattern[0..m-1], write a function Search(string input, string pattern) that prints all occurrences of pattern[] in input[]. You may 
        /// assume that n > m.
        /// </summary>
        /// <param name="input">The input string</param>
        /// <param name="pattern">The patter to search</param>
        /// <returns>The index where the pattern starts; otherwise null</returns>
        /// <example> input[] =  "THIS IS A TEST TEXT", pattern[] = "TEST", output:10</example>
        /// <see cref="http://www.geeksforgeeks.org/searching-for-patterns-set-3-rabin-karp-algorithm/"/>
        public static int Search(string input, string pattern)
        {
            return -1;
        }

    }
}
