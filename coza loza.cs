using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			for (int x = 1; x < 110; x++)

			{

				if (x % 12 == 0)
				{
					Console.WriteLine();
				}

				else if (x % 3 == 0 && x % 5 == 00 && x % 7 == 0)
				{
					Console.Write(" cozalozawoza ");

				}

				else if (x % 5 == 00 && x % 7 == 0)
				{
					Console.Write(" lozawoza ");
				}

				else if (x % 3 == 0 && x % 5 == 0)
				{


					Console.Write(" cozaloza ");

				}
				else if (x % 3 == 0 && x % 7 == 0)
				{

				}

				else if (x % 3 == 0)
				{
					Console.Write(" coza ");

				}
				else if (x % 5 == 0)
				{
					Console.Write(" loza ");

				}
				else if (x % 7 == 0)
				{
					Console.Write(" woza ");

				}

				else
				{
					Console.Write("" + x + "  ");

				}



			}
			Console.ReadKey();
		}

	}
}