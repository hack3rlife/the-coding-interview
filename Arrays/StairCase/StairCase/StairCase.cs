using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class StairCase
    {
        /// <summary>
        /// Draw a staircase of height N in the format given below
        /// </summary>
        /// <example>
        /// 
        /// Draw(6)
        /// #
        /// ##
        /// ###
        /// ####
        /// #####
        /// ######
        /// </example>
        /// <param name="n">The height</param>
        public static string[,] DrawRight(int n)
        {
            string[,] matrix = new string[n, n];

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[i, i - j] = "#";
                    Print(matrix);
                }
            }

            return matrix;
        }

        /// <summary>
        /// Draw a staircase of height N in the format given below
        /// </summary>
        /// <example>
        /// Draw(6)
        ///       #
        ///      ##
        ///     ###
        ///    ####
        ///   #####
        ///  ######
        /// </example>
        /// <param name="n">The height</param>
        public static string[,] DrawLeft(int n)
        {
            string[,] matrix = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = n - i - 1; j < n; j++)
                {
                    matrix[i, j] = "#";
                    Print(matrix);
                }
            }

            return matrix;
        }

        public static void Print(string[,] m)
        {
            int length = m.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (m[i, j] == null)
                        Debug.Write(" ");
                    else
                        Debug.Write(m[i, j]);
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("");
        }
    }
}
