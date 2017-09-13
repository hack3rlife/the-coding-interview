using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.bitmanipulation
{
    /// <summary>
    /// In mathematics, the power set (or powerset) of any set S is the set of all subsets of S, including the empty set and S itself, variously denoted as P(S), ℘(S) (using the 
    /// "Weierstrass p"), P(S), ℙ(S), or, identifying the powerset of S with the set of all functions from S to a given set of two elements, Pow(2,s)
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Power_set"/>
    public static class PowerSet
    {
        /// <summary>
        /// Power set P(S) of a set S is the set of all subsets of S.
        /// <![CDATA[
        /// For example S = {a, b, c} then P(s) = {{}, {a}, {b}, {c}, {a,b}, {a, c}, {b, c}, {a, b, c}}.
        /// ]]>
        /// </summary>
        /// <see cref="http://www.geeksforgeeks.org/power-set/"/>
        public static void Get(string[] set)
        {
            var powsize = GetPowSize(set);
            var length = set.Length;

            for (int i = 0; i < powsize; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        Debug.Write($"{set[j]} ");
                    }
                }

                Debug.WriteLine(string.Empty);
            }
        }

        private static int GetPowSize(string[] set)
        {
            return (int)Math.Pow(2, set.Length);
        }
    }
}
