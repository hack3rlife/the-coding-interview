using System;
using System.Diagnostics;

namespace com.hack3rlife.dynamicprogramming
{
    /// <summary>
    /// In information theory and computer science, the Levenshtein distance is a string metric for measuring the difference between two sequences. Informally, the Levenshtein distance 
    /// between two words is the minimum number of single-character edits (insertions, deletions or substitutions) required to change one word into the other.
    /// 
    /// Levenshtein distance may also be referred to as edit distance, although that term may also denote a larger family of distance metrics
    /// </summary>
    /// <see cref=""/>
    public class LavenshteinDistance
    {
        /// <summary>
        /// Given two strings str1 and str2 and below operations that can performed on str1. Find minimum number of edits (operations) required to convert ‘str1’ into ‘str2’.
        /// 1. Insert
        /// 2. Remove
        /// 3. Replace
        /// </summary>
        /// <example>
        /// </example>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/dynamic-programming-set-5-edit-distance/"/>
        public static int Get(string s1, string s2)
        {
            var rows = s1.Length + 1;
            var cols = s2.Length + 1;

            int[,] result = new int[rows, cols];

            //row 1
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = i;
                Print(result);
            }

            //col 1
            for (int j = 0; j < cols; j++)
            {
                result[0, j] = j;
                Print(result);

            }


            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        result[i, j] = result[i - 1, j - 1];
                    }
                    else
                    {
                        result[i, j] = Min(result, i, j) + 1;
                    }

                    Print(result);

                }
            }

            return result[rows - 1, cols - 1];

        }

        private static int Min(int[,] input, int i, int j)
        {
            var adjRow = new int[] { 0, -1, -1 };
            var adjCol = new int[] { -1, -1, 0 };

            //left
            int a = input[i + adjRow[0], j + adjCol[0]];
            //diag
            int b = input[i + adjRow[1], j + adjCol[1]];
            //top
            int c = input[i + adjRow[2], j + adjCol[2]];

            int smallest = Math.Min(Math.Min(a, b), c);

            return smallest;
        }

        private static void Print(int[,] input)
        {
            int x = input.GetLength(0);
            int y = input.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Debug.Write(string.Format(" {0} ", input[i, j]));
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");
        }
    }
}
