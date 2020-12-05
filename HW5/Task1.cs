using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW5
{
	class Task1
	{

		public Task1()
		{
			Console.WriteLine(WO());
			Console.WriteLine(WT());
			Console.ReadKey();
			
		}

		bool WO()
		{
			int i = 0;
			Console.WriteLine("Введите пароль");
			do
			{
				string pass = Console.ReadLine();

				bool m=true;

				for (int j = 0; j < pass.Length; j++)
				{
					if (!char.IsLetterOrDigit(pass[j])||char.IsDigit(pass[0])) m = false;

				}
				
				

				if (pass.Length > 1 && pass.Length < 11 && m) return true;

				i++;
			} while (i<3);
			return false;

		}

		bool WT()
		{
			Regex myReg = new Regex("[A-Za-z]+[A-Za-z0-9]{1,9}");
			return myReg.IsMatch(Console.ReadLine());
		}



	}
}
