using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Task1
			//         Finder fn = new Finder();
			//fn.View();
			//fn.Number();
			//Console.ReadKey();

			#endregion

			#region Task2

			//Massiv m = new Massiv(10, 2);
			//m.Files("new file");
			//m.Show();
			//Console.ReadKey();


			#endregion

			#region Task3
			DualMat m = new DualMat(10,2);
			m.Write("task4");

			m.Read("task4");
			

			m.Show();

			Console.ReadKey();

			#endregion
		}
	}
}
