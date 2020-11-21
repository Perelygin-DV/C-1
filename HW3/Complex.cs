using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
	/// <summary>
	/// Комлпексные числа через структуру
	/// </summary>
	struct Complex
	{
		public double im;
		public double re;

		public Complex Plus(Complex x)
		{
			Complex y;
			y.im = im + x.im;
			y.re = re + x.re;
			return y;

		}

		public Complex Minus(Complex x)
		{
			Complex y;
			y.im = im - x.im;
			y.re = re - x.re;
			return y;
		}

		public Complex Multi(Complex x)
		{
			Complex y;
			y.im = (im * x.im - re * x.re);
			y.re = (im * x.re + re * x.im);
			return y;
		}


		public Complex Test()
		{
			Complex Z;
			Z.im = 2;
			Z.re = 3;
			return Z;

		}

		public string ToString()
		{ return re + " + " + im + " i "; }


	}

	class COMPLEX
	{
		double im;
		double re;

		public COMPLEX()
		{
			im = 0;
			re = 0;
		}

		public COMPLEX(double im, double re)
		{
			im = im;
			re = re;
		}



		public COMPLEX Plus(COMPLEX x)
		{
			COMPLEX y = new COMPLEX();
			y.im = im + x.im;
			y.re = re + x.re;
			return y;

		}

		public COMPLEX Minus(COMPLEX x)
		{
			COMPLEX y = new COMPLEX();
			y.im = im - x.im;
			y.re = re - x.re;
			return y;
		}

		public COMPLEX Multi(COMPLEX x)
		{
			COMPLEX y = new COMPLEX();
			y.im = (im * x.im - re * x.re);
			y.re = (im * x.re + re * x.im);
			return y;
		}

       public double Im
		{
			get { return im; }
			set { if (value > 0) im = value; }
		}

		public double Re
		{
			get { return re; }
			set { re = value; }
		}

		public string ToString()
		{ return re + " + " + im + " i "; }


	}


}
