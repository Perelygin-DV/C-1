using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
	public delegate double FUNC(double a, double b);
	class Task1
	{
	
		
		public Task1() { }

		public double AX (double a, double x)
		{
			return  (double)Math.Pow(x, 2) * a;
		}

		public double SIN (double a, double x)
		{
			return a * Math.Sin(x);
		}

		public void Display (int a, int x, double step, FUNC L)
		{
			
				for (double n = a; n < x; n += step)
				{
					Console.WriteLine($"{n,3}: {Math.Round(L(a, n),2)}");
				}
			
			
		}


	}
}
