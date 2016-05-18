using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    public class StairCase
    {
        public static void DrawRight(int n)
        {
            string[,] matrix = new string[n, n];

            for (int i = n-1; i>0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[i, i - j] = "#";
                }
                
                Print(matrix);
            }
        }

        public static void DrawLeft(int n)
        {
            string[,] matrix = new string[n, n];

            for (int i =0; i <n; i++)
            {
                for (int j = n-i-1; j < n; j++)
                {
                    matrix[i, j] = "#";
                }

                Print(matrix);
            }
        }

        public static void Print(string[,] m)
        {
            int length = m.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if(m[i,j] == null)
                        System.Diagnostics.Debug.Write(" ");
                    else
                        System.Diagnostics.Debug.Write(m[i, j]);
                }
                System.Diagnostics.Debug.WriteLine("");
            }
        }
    }
}
