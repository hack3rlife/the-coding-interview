using System.Diagnostics;

namespace com.hack3rlife.arrays
{
    public static class LightsOut
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public static void TurnOff(int[,] input)
        {
            int rlength = input.GetLength(0);
            int clength = input.GetLength(1);

            bool[] rows = new bool[rlength];
            bool[] cols = new bool[clength];

            for (int i = 0; i < rlength; i++)
            {
                for (int j = 0; j < clength; j++)
                {
                    Debug.Write(string.Format(" {0} ", input[i, j]));

                    if (input[i, j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");

            for (int i = 0; i < rlength; i++)
            {
                for (int j = 0; j < clength; j++)
                {
                    if (rows[i] == true || cols[j] == true)
                    {
                        input[i, j] = 0;
                    }

                    Debug.Write(string.Format(" {0} ", input[i, j]));
                }

                Debug.WriteLine("");
            }
            Debug.WriteLine("");

        }
    }
}
