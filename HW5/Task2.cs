using System;
using System.Linq;

namespace HW5
{
	internal class Task2
	{

		public Task2()
		{
			int m = 5;
			char s = 'д';

			Words [] str = Read(m,s);

			Console.WriteLine($"Слова, в которых более {m} символов");
			More(str);
			Console.WriteLine($"Слова, с максимальным числом символов");
			Max(str);

			string[] excend = new string[str.Length];
			int j = 0;
			for (int i = 0; i < str.Length; i++)
			{if (str[i].End == true) { excend[j] = str[i].Word; j++; };

			}

			foreach(var el in excend)
			{
				Console.Write (el+" ");
			}

			Console.ReadLine();

		}

		Words[] Read(int n, char s)
		{
			string r = Console.ReadLine();
			string[] raws = r.Split(new char[] { ' ', ',', '.' });

			int length = raws.Length;
			int max = int.MinValue;
			Words[] fin = new Words[length];
			
			for(int i = 0; i < length; i++)
			{
				fin[i] = new Words();			
				fin[i].Word = raws[i];
				if (raws[i].Length > n) fin[i].More = true;
				if (s == raws[i][raws[i].Length - 1]) fin[i].End = true;
				if (raws[i].Length > max) max = raws[i].Length;

			}
			for (int i = 0; i < length; i++)
			{
				if (fin[i].Word.Length == max) fin[i].Max = true;

			}


			return fin;
		}

		public void More(Words[] m)
		{
			for (int i = 0; i < m.Length; i++)
			{
				if (m[i].More == true)
				{
					Console.Write($"|{m[i].Word}| ");
				}
			}
			Console.WriteLine();

		}


		public void End(Words[] m)
		{
			for (int i = 0; i < m.Length; i++)
			{
				if (m[i].End == true)
				{
					Console.Write($"|{m[i].Word}| ");
				}
			}

		}

		public void Max(Words[] m)
		{
			for (int i = 0; i < m.Length; i++)
			{
				if (m[i].Max == true)
				{
					Console.Write($"|{m[i].Word}| ");
				}
			}
			Console.WriteLine();

		}







	}
}