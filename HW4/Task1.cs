using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
	class Finder
	{
		Random rnd = new Random();
		
		int[] m = new int[20];

		public Finder()
		{

			for (int i = 0; i < m.Length; i++)
			{
				m[i] = rnd.Next(-10, 10);
			}

		}

		public void View()
		{
			for (int i = 0; i < m.Length; i++)
			{
				Console.Write($"{m[i]}  ");

			}
		}

		public void Number ()
		{
			int count = 0;
			for (int i = 0; i < m.Length-1; i++)
			{
				if (m[i] % 3 == 0 | m[i + 1] % 3 == 0) count++;
			}
			Console.WriteLine($"\n число : {count}");
		}



		


	}
}
