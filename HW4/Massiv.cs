using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
	class Massiv
	{

		int[] a;
		public Massiv(int n, int c)
		{
			a = new int[n];
		
			for (int i = 0; i < n; i++)
			{

				a[i] = i * c;

			}
		}

		public int M { get; set; }

		public int Sum
		{
			
			get 
			{
			int sum = 0;
			for (int i = 0; i< a.Length; i++)
			{
				sum += a[i];

			}
				return sum;


			}
		}


		public int Inverse
		{
			set
			{
				for (int i = 0; i < a.Length; i++)
				{
					a[i] *= -1;
				}
			}
		}

		public void Multi(int n)
		{
			
				for (int i = 0; i < a.Length; i++)
				{
					a[i] *= 2;
				}
			
		}

		public int MaxCount()
		{
			int count = 0;
			int max = int.MinValue;
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
					count = 1;
				}
				else count++;
				
			}
			return max;
		}


		public void Files (string filename)
		{
			
			
			if (!File.Exists(filename))
			{
				

				StreamWriter sw = new StreamWriter(filename);
				for (int i = 0; i < a.Length; i++)
				{
					sw.WriteLine(a[i]);


				}
				sw.Close();

			

			};
			if (File.Exists(filename))
			{
				StreamReader sr = new StreamReader(filename);

				for (int i = 0; i < a.Length; i++)
				{
					a[i] = int.Parse(sr.ReadLine())*2;
					

				}
				sr.Close();
			
				
			}


		
		}

		public void Show()
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
		}
		//el




	}
}
