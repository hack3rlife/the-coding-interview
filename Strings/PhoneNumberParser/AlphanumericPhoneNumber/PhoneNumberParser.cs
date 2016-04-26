/*
 * @autor: Some smart guy on internet
 * @date: 12/05/2015
 * @project: Palindrome
 * 
 */

namespace com.hack3rlife.strings
{
   public  static class PhoneNumberParser
    {
        /// <summary>
        /// Print the actual phone number when given an alphanumeric phone number. 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetPhoneNumber(string number)
        {
            string map = "22233344455566677778889999";

            string result = string.Empty;

            foreach (var n in number)
            {
                if (n >= 48 && n <= 57)             //[0-9]
                    result += n;
                else if (n >= 65 && n <= 90)        //[A-Z]
                    result += map[n - 65];
                else if (n >= 97 && n <= 122)        //[a-z]
                    result += map[n - 97];
            }

            return result;
        }      
    }
}
