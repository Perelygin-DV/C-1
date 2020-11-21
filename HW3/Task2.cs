using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
	public class VVOD
	{
		private int c;
		int sum;
		bool flag = false;
		public void Summa()
		{
			sum = 0;
			Console.WriteLine("Введите числа. 0-выход из цикла");
			do
			{

				flag = int.TryParse(Console.ReadLine(), out c);
				if (c % 2 != 0 && c>0) sum += c;
			}
				while (c != 0 && flag) ;
		}

		public void Summa2()
		{
			Console.WriteLine("Введите числа. 0-выход из цикла");
			flag = false;
			sum = 0;

			do
			{
				try
				{
					c = Convert.ToInt32(Console.ReadLine());
					if (c % 2 != 0 && c > 0) sum += c;
					flag = false;
				}
				catch (FormatException ex)
				{

					Console.WriteLine("Неправильный формат данных");
					Console.WriteLine(ex.Message);
					flag = true;

				}
				catch (Exception ex)
				{
					Console.WriteLine("Неправильно ввели данные");
					Console.WriteLine(ex.Message);
					flag = true;

				}
			}
			while (!flag&& c!=0);
		}

		public   override string ToString()
		{
			return $"Сумма чисел: {sum}";
		}
	}



}
