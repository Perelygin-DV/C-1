using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
	class Program
	{
		/// <summary>
		/// Возврат минимального из трех
		/// </summary>
		/// <param name="a">аргумент 1</param>
		/// <param name="b">аргумент 2</param>
		/// <param name="c">аргумент 3</param>
		/// <returns></returns>
		static int MINOF3(int a, int b, int c)
		{
			return a < b && a < c ? a : b < c ? b : c;

		}
		static void Main(string[] args)
		{

			#region task1
			Console.WriteLine(MINOF3(1, 3, 5));




			#endregion
			Console.ReadLine();
		}
	}
}
