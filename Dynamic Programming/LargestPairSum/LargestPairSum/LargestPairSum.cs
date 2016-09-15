using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hack3rlife.algorithms
{
	public class LargestPairSum
	{
		public static int Find(int[] input)
		{
			int first = input[0];
			int second= input[1];

			if(second>first)
			{
				first^=second;
				second^=first;
				first^=second;
			}

			for (int i = 3; i < input.Length; i++)
			{
				if (input[i] > first)
				{
					second = first;
					first = input[i];
				}
				else if(input[i] > second && input[i] <= first) 
				{
					second = input[i];
				}
			}

			return first + second;
		}
	}
}
