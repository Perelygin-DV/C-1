using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
	class Task2
	{

		public delegate double FUNC(double x);
		List<FUNC> LS = new List<FUNC> { };

		public Task2()
		{
			INIT();

			SaveFunc("task2.txt", 1, 100, 1, Choice());
			Console.WriteLine(Load("task2.txt"));
			
			
			//Console.WriteLine(Choice(Convert.ToDouble(Console.ReadLine())));

		}


		void INIT()
		{
			
			LS.Add(F);
			LS.Add(A);
			LS.Add(B);
		}

		 FUNC Choice()
		{
			Console.WriteLine("У вас имеются следующие методы. Выберите по нажатию:");

			int i = 0;

			foreach (FUNC el in LS)
			{

				Console.WriteLine($"{el.Method}: клавиша {i++}  ");

			}

			i = Key();

			return LS[i];

		}
			
		

		public int Key()
		{
			char m;
			bool tr = false;
			int s=-1;
			do
			{
				m = Console.ReadKey().KeyChar;
				switch (m)
				{
					case '0': s = 0; tr = true; break;
					case '1': s = 1; tr = true; break;
					case '2': s = 2; tr = true; break;
					//case '3': s = 3; tr = true; break;
						
				}


			}

			while (!tr);

			return s;

		}







		public double F(double x)
		{
			return x * x - 50 * x + 10;
		}

		public double A(double x)
		{
			return x - 100;
		}

		public double B(double x)
		{
			return x * x - Math.PI;
		}


		public void SaveFunc(string FileName, double a, double b, double h, FUNC A)
		{
			
			FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);
			double x = a;
			while (x <= b)
			{
				bw.Write(A(x));
				x += h;
			}

			bw.Close();
			fs.Close();

		}

		public double Load(string FileName)
		{
			FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
			BinaryReader bw = new BinaryReader(fs);
			double min = double.MaxValue;
			double d;
			for (int i = 0; i < fs.Length/sizeof(double); i++)
			{
				d = bw.ReadDouble();
				if (d < min) min = d;
			}
			bw.Close();
			fs.Close();
			return min;
		}





	}
}
