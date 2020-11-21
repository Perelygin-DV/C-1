using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{


	class Program
	{
		static void Main(string[] args)
		{
			Complex complex1;
			complex1.re = 1;
			complex1.im = 1;
			Complex complex2;
			complex2.re = 2;
			complex2.im = 2;

			COMPLEX com1 = new COMPLEX();
			com1.Re = 1;
			com1.Im = 1;

			COMPLEX com2 = new COMPLEX();
			com2.Re = 2;
			com2.Im = 2;



			Complex result2 = complex1.Plus(complex2);
			Console.WriteLine( $"Сложение:{result2.ToString()} \n Перемножение: {complex1.Multi(complex2).ToString()} \n  ");

			Console.WriteLine($"Сложение:{com1.Plus(com2).ToString()} \n Перемножение: {com1.Multi(com2).ToString()} \n  ");


			Console.ReadKey();
		}
	}
}
