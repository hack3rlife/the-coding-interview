/* 
 * @autor: hectorea
 * @date: 03/08/12
 * @project: RomanNumerals
 * @reference: 
 *  http://es.wikipedia.org/wiki/Numeraci%C3%B3n_romana
 *  http://en.wikipedia.org/wiki/Roman_numerals
 *  http://www.dacostabalboa.es/wp-content/uploads/2008/05/numeros-romanos.png
 *  http://www.blackwasp.co.uk/NumberToRoman.aspx
 *  http://www.onlineconversion.com/roman_numerals_advanced.htm
 *  http://www.ehow.com/how_5060146_convert-number-roman-numerals.html
 *  http://www.ehow.com/how_8502493_convert-roman-characters-numbers.html
 *  http://www.ehow.com/how_7799048_convert-arabic-numbers.html
*/

using System;
using System.Text;

namespace com.hack3rlife.strings
{
    /// <summary>
    /// The numeric system represented by Roman numerals originated in ancient Rome and remained the usual way of writing numbers throughout Europe well into the late Middle Ages.
    /// -> The first rule is that the letters can be repeated several times, with the values of each being additive.
    /// -> The second rule states that the larger numerals must be placed to the left of the smaller numerals to continue the additive combination.
    /// -> The third rule allows for a small-value numeral to be placed to the left of a larger value
    /// </summary>
    public class RomanNumerals
    {
        /// <summary>
        /// Int32 Key values 
        /// </summary>
        readonly static int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        /// <summary>
        /// Roman Number Key values 
        /// </summary>
        readonly static string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roman"></param>
        /// <returns></returns>
        public static string RomanToNumber(string roman)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The algorithm converts an integer value into Roman numerals using a iterative process. The resultant value is returned as a string to the calling function. 
        /// To remove the problems of displaying Roman numerals of four thousand or greater, a restriction to values between zero and 3,999 is enforced
        /// </summary>
        /// <param name="number">The input must be in the range of 1 - 3999</param>
        /// <returns>The equivalent represention of <para>number</para> in roman number</returns>
        public static string NumberToRoman(int number)
        {
            if (number < 1 || number > 3999)
                throw new ArgumentOutOfRangeException("The input must be in the range of 1 - 3999");

            string result = string.Empty;

            for (int i = 0; i < 13; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result += numerals[i];
                }
            }

            return result.ToString();
        }

    }
}
