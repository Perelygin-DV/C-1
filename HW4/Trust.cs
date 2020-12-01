using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
	class Trust
	{
		string[,] quest;
		Random rnd = new Random();
		public Trust(string file)
		{
			int count = File.ReadAllLines(file).Length;
			quest = new string[count,2];
			StreamReader sr = new StreamReader(file);

			char[] e = new char[] { ',' };
			
			for(int i=0; i<quest.GetLength(0); i++)
			{

				string[] line = sr.ReadLine().Split(e, StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < quest.GetLength(1); j++)
				{
					quest[i,j] = line[j];

				}

			}
			sr.Close();


		}

		public void Quest(ref int t)
		{
			Stack<int> ts = new Stack<int>();
			int tot = 0;
			int q;
			int a;
			do
			{
				q = rnd.Next(0, quest.GetLength(0)-1);
				if (!ts.Contains(q))
				{
					Console.WriteLine($"{quest[q,0]} да-1,нет-0");
					a = Convert.ToInt32(Console.ReadKey().KeyChar);
					Console.WriteLine($"|{quest[q,1]}| |{a}|");
					if ((quest[q,1] == " Да"&a==49) || (quest[q, 1] == " Нет" & a == 48)) t++;
					ts.Push(q);
					tot++;
				}
				
			}
			while (tot < 5);

		}

	}
}
