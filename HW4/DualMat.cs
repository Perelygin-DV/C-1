using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
	class DualMat
	{
		int[,] a;
		Random rnd = new Random();

		public DualMat()
		{

		}
		public DualMat(int r,int c)
		{
			a = new int[r, c];
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{

					a[i, j] = rnd.Next(10);

				}

			}
		}


		public void Sum()
		{
			int sum = 0;
			foreach(int el in a)
			{
				sum += el;
			}

			Console.WriteLine(sum);
		}


		public void Sum(int m)
		{
			int sum = 0;
			foreach(int el in a)
			{
				if(el>m) sum += el;
			}

			Console.WriteLine(sum);
		}


		public int Min
		{
			get
			{ int min = int.MaxValue;
				foreach(int el in a)
				{
					if (el < min) min = el;
				}
				return min;
			}
		}


		public void Write(string path)
		{
			string l = string.Empty;
			StreamWriter sw = new StreamWriter(path);
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					l += $"{a[i, j]} ";
					sw.Write($"{a[i, j]} ");
				}
				sw.WriteLine();
				l = string.Empty;
			}
			sw.Close();
		}

		public void Read(string path)
		{
			char[] separators = new char[] { ' ' };
			string l = string.Empty;
			StreamReader st = new StreamReader(path);
			int r = 0;
			int c = st.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
			
			while (!st.EndOfStream)
			{
					st.ReadLine();
					r++;
				
			};
			a = new int[r, c];

			//string[] str; 
			st.Close();
			StreamReader st2 = new StreamReader(path);


			for (int i = 0; i < r; i++)
			{
				string [] str = st2.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < c; j++)
				{

					a[i, j] = Convert.ToInt32(str[j]);

				}


			}
			st2.Close();
			
			
		}

		public void Show()
		{
			
			for (int i = 0; i < a.GetLength(0) ; i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write(a[i, j]+" ");
				}
				Console.WriteLine();
			}
		}

	}
}
