using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
	class Frac
	{
		int num;
		int den;

		int T;


		public int Num
		{
			get { return num; }
			set { num = value; }
		}
		public int Den
		{
			get { return den; }
			set { if (value != 0) { den = value; };  }
		}

		public Frac Sum (Frac x)
		{
			Frac y = new Frac();
			y.num = num * x.den + x.num * den;
			y.den = den * x.den;
			return y;
		
		}

		public Frac Dif(Frac x)
		{
			Frac y = new Frac();
			y.num = num * x.den - x.num * den;
			y.den = den * x.den;
			return y;

		}

		public Frac Mult(Frac x)
		{
			Frac y = new Frac();
			y.num = num * x.num;
			y.den = den * x.den;
			return y;

		}

		public Frac Divi(Frac x)
		{
			Frac y = new Frac();
			y.num = num * x.den;
			y.den = den * x.num;
			return y;
		}

		int NOD(int a, int b)
		{
			a= a < 0 ? a * (-1) : a;
			b= b < 0 ? b * (-1) : b;

			while (a != b)
				{
					if (a > b) { a = a - b; } else b = b - a;
				}
				return b;
			
		}


		public override string ToString()
		{

			if (num > den)
			{

				T = 0;
				do
				{
					num -= den;
					T++;

				}
				while (num > den);
				int nod = NOD(num, den);
				return $"{T} {num / nod}/{den / nod}";
			}

			else
			{
				int nod = NOD(num, den);
				return $"{num/nod } / {den/nod }";
			}
		}











	}
}
