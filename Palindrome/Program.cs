// See https://aka.ms/new-console-template for more information
using System;

namespace Palindrome
{
	class Program
	{
		public static void Main()
		{
			StandardMessages.StartAplication();

			var input = StringCapture.Capture();
			var output = new PalindromeCapture();
			var check = output.Check(input);
			Console.WriteLine(check);
			
			StandardMessages.EndApplication();
		}
	}
}
