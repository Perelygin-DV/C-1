using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
	class Program
	{
		const int iIterations = 20000;
		static void Main()
		{
			{
				//Task1 m = new Task1();

				//Task2 m = new Task2();

				//Task3 n = new Task3();
				//string a = "один";
				//string b = "нидо";


				//Console.WriteLine($"Стандартные средства: {n.Stand(a,b)}");

				//Console.WriteLine($"Свой метод: {n.Mine(a, b)}");

				//Console.ReadLine();

				#region task4

				Task4 tsk = new Task4();
				tsk.Best();
				tsk.Worst();
				Console.ReadLine();
				
				#endregion


			}
		}
	}
}


