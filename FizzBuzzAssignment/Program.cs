// See https://aka.ms/new-console-template for more information

using System;

namespace FizzBuzzAssignment
{
	class Program
	{
		public static void Main(string[] args)
		{


			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 && i % 5 != 0)
				{
					Console.Write("Fizz" + ",");
				}
				else if (i % 5 == 0 && i % 3 != 0)
				{
					Console.Write("Buzz" + ",");
				}
				else if (i % 5 == 0 && i % 3 == 0)
				{
					Console.Write("FizzBuzz" + ",");
				}
				else
				{
					Console.Write(i + ",");
				}



			}





		}
	}
}


