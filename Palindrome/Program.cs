// See https://aka.ms/new-console-template for more information
using System;

namespace Palindrome
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter some string");
			string enteredString = Console.ReadLine();
			
			char[] enteredStringToChar = enteredString.ToCharArray();
			Array.Reverse(enteredStringToChar);
			string reversedString = new string(enteredStringToChar);
			bool isPalindrome = false;
			if(enteredString == reversedString)
            {
				isPalindrome = true;
            }
            Console.WriteLine(isPalindrome);
		}
	}
}
