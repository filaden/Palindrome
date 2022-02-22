using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeCapture
    {
        public  bool Check(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            bool isPalindrome = false;
            if (input == reversedString)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
