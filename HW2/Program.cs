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

		static int NUMOFDIGIT (int a)
		{
			int count = 0;
			while(a!=0)
			{ a /= 10;count++; };
			return count;
		}

		/// <summary>
		/// Проверка логина и пароля. У вас 3 попытки
		/// </summary>
		/// <returns></returns>
		static bool LogPass()
		{
			bool status = false;
			int count = 3;
			string log, pass, amount;
	

			do
			{
				switch (count)
				{
					case 3: amount = "три попытки"; break;
					case 2: amount = "две попытки"; break;
					case 1: amount = "одна попытка"; break;


					default:
						amount = "Одна попытка";
						break;
				}

				Console.WriteLine($"Введите логин и пароль. У вас {amount} ");
				Console.WriteLine("Введите логин");
				log = Console.ReadLine();
				Console.WriteLine("Введите пароль");
				pass = Console.ReadLine();

				if (log == "root" && pass == "geekbrains") status = true;


				count--;

			}
			while (count != 0);
			return status;
		}

		static void Main(string[] args)
		{

			#region task1
			Console.WriteLine(MINOF3(1, 3, 5));




			#endregion


			#region task 2
			
			Console.WriteLine($"Количество цифр:{NUMOFDIGIT(1500000)}");

			#endregion

			#region task3

			Console.WriteLine(LogPass());


			#endregion


			Console.ReadLine();
		}
	}
}
