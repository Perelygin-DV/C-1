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

		static void NotZero()
		{
			int neg = 0;
			int odd = 0;
			int a=1;
			Console.WriteLine("Вводите числа");
			do
			{
				Console.Write("  ");
				a = Convert.ToInt32(Console.ReadLine());
				
				if (a % 2 != 0) odd++;
				if (a < 0) neg++;

			}
			while (a != 0);


			Console.WriteLine($"Количество отрицательных чисел:{neg}, Количество нечетных чисел: {odd}"); 



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
			//Console.WriteLine(MINOF3(1, 3, 5));




			#endregion


			#region task 2
			
			//Console.WriteLine($"Количество цифр:{NUMOFDIGIT(1500000)}");

			#endregion

			#region task 3

			//NotZero();

			#endregion



			#region task4

			//Console.WriteLine(LogPass());


			#endregion

			GoodNum(100);


			int a = 1;
			int b = 3;

			Console.ReadLine();
		}



		static void GoodNum(int v)
		{
			int count = 0;
			int a = 1;
			int temp = 0;
			int c;
			while (a < v)
			{
				c = a;
				while (a != 0)
				{
					temp += a % 10;
					a /= 10;

				}
				if (c % temp == 0) count++;
				c++;
				a = c;
				temp = 0;



			}
			Console.WriteLine($"Число хороших чисел в диапазоне от 0 до {v} = {count}");

		}
	}
}
