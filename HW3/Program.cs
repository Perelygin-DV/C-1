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

			#region Task1
			//        	Complex complex1;
			//complex1.re = 1;
			//complex1.im = 1;
			//Complex complex2;
			//complex2.re = 2;
			//complex2.im = 2;

			//COMPLEX com1 = new COMPLEX();
			//com1.Re = 1;
			//com1.Im = 1;

			//COMPLEX com2 = new COMPLEX();
			//com2.Re = 2;
			//com2.Im = 2;



			//Complex result2 = complex1.Plus(complex2);
			//Console.WriteLine( $"Сложение:{result2.ToString()} \n Перемножение: {complex1.Multi(complex2).ToString()} \n  ");

			//Console.WriteLine($"Сложение:{com1.Plus(com2).ToString()} \n Перемножение: {com1.Multi(com2).ToString()} \n  ");

			#endregion


			#region Task2

			//VVOD task2 = new VVOD();
			//task2.Summa();
			//task2.Summa2();
			//Console.WriteLine(task2.ToString());





			#endregion


			#region Task3

			Frac x1 = new Frac();
			x1.Num = 1;
			x1.Den = 2;


			Frac x2 = new Frac();
			x2.Num = 3;
			x2.Den = 4;

			Frac res = new Frac();

			Console.WriteLine($"Сложение: {x1.Sum(x2)} \n Вычитание: {x1.Dif(x2)} \n Умножение: {x1.Mult(x2)} \n Деление: {x1.Divi(x2)} ");

			int a = 4; int b = 6;
			while (a != b)
			{
				if (a > b) { a = a - b; } else b = b - a;
			}
			Console.WriteLine(a); ;

			#endregion

			Console.ReadKey();
		
		
		}
	}
}
