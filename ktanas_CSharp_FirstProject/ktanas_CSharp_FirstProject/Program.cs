using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktanas_CSharp_FirstProject
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 0;
			int y = 0;

			Console.WriteLine("Enter x");
			x = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter y");
			y = int.Parse(Console.ReadLine());

			Console.WriteLine("Select an operation");
			Console.WriteLine("\ta Add");
			Console.WriteLine("\ts Subtract");
			Console.WriteLine("\tm Multiply");
			Console.WriteLine("\td Divide");
			Calculate(x, y);
		}

		static void Calculate(int x, int y)
		{
			try
			{
				switch (Console.ReadLine())
				{
					case "a":
						Console.WriteLine($"{x}+{y}={x + y}");
						break;
					case "s":
						Console.WriteLine($"{x}-{y}={x - y}");
						break;
					case "m":
						Console.WriteLine($"{x}*{y}={x * y}");
						break;
					case "d":
						Console.WriteLine($"{x}/{y}={x / y}");
						break;
					default:
						Console.WriteLine("Incorrect operation");
						break;
				}
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine($"Pamiętaj cholero nie dzielić przez zero! \n{e.Message}");
			}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
				Console.ReadLine();
			}
		}
	}
}
