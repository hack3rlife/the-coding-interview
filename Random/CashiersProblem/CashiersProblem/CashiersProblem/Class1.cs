using System.Collections.Generic;
using System.Diagnostics;

namespace com.hack3rlife.random
{
    /*
      
    Cashiers Problem (~45 min)
      
    Given a list of transactions, How can we calculate the frequency
    counts of all possible item-sets?
      
    For example,
      
    [INPUT] list of transactions
    | -- | -----------------------------|
    | ID | Purchased items              |
    | -- | -----------------------------|
    | 1  | apple, banana, lemon         |
    | 2  | banana, berry, lemon, orange |
    | 3  | banana, berry, lemon         |
    | -- | -----------------------------|
      
      
    [OUTPUT] frequency counts of all possible item-sets. Note: some
    outputs are omitted for brevity.
    | ---------------------------- | --------- |
    | Itemset                      | Frequency |
    | ---------------------------- | --------- |
    | apple, banana                | 1         |
    | apple, lemon                 | 1         |
    | banana, berry                | 2         |
    | banana, lemon                | 3         |
    | ...                                      |
    | apple, banana, lemon         | 1         |
    | banana, berry, lemon         | 2         |
    | ...                                      |
    | banana, berry, lemon, orange | 1         |
    | ...                                      |
    | ---------------------------- | --------- |
    */

    public class Cashier
    {
        public static void Calculate(string[] input)
        {
            if (input == null || input.Length == 0)
                return;

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                string[] currLine = input[i].Split(new char[] { ',' });

                Combine(currLine, string.Empty, 0, ref result, ref dictionary);
            }

            foreach (KeyValuePair<string, int> item in dictionary)
            {
                if (item.Key.Split(new char[] { ' ' }).Length >= 3)
                    Debug.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }

        private static void Combine(string[] input, string output, int current, ref string result, ref Dictionary<string, int> dictionary)
        {
            for (int i = current; i < input.Length; i++)
            {
                output += input[i] + " ";
                result += output + "#";

                if (dictionary.ContainsKey(output))
                    dictionary[output]++;
                else
                    dictionary.Add(output, 1);

                Combine(input, output, i + 1, ref result, ref dictionary);

                var tmp = output.TrimEnd().Split(new char[] { ' ' });
                output = string.Empty;

                for (int j = 0; j < tmp.Length - 1; j++)
                    output += tmp[j] + " ";

            }
        }

    }
}