// See https://aka.ms/new-console-template for more information

using System;

namespace FizzBuzzAssignment
{
	class Program
	{
		public static void Main(string[] args)
		{
			string input;
			
			Console.Write("Enter a Number ");
			input = Console.ReadLine();
			try
			{
				int result = Int32.Parse(input);
				if(result% 3==0 && result%5!=0)
                {
					Console.WriteLine("Fizz");
				}
				else if(result% 5==0&& result%3!=0)
                {
					Console.WriteLine("Buzz");
				}
				else if (result % 5 == 0 && result%3==0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else
                {
					Console.WriteLine(result);
                }
				//Console.WriteLine(result);
			}
			catch (FormatException)
			{
				Console.WriteLine($"Unable to parse '{input}'");
			}
			
		}
	}
}


