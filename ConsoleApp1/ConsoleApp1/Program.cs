using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static double LL(double x1, double x2, double y1, double y2)
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}

		static void Main(string[] args)
		{
			#region task 1
			//Console.WriteLine("Введите имя");
			//string name = Console.ReadLine();
			//Console.WriteLine("Введите возраст");
			//double age = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("введите рост");
			//double h = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Введите вес");
			//double w = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine($"Имя: {name}, возраст: {age}, рост: {h}, вес: {w}");



			#endregion

			#region task 2
			//double I = h / (w * w);
			//Console.WriteLine("Индекс массы:" + I);


			#endregion

			#region task3
			//Console.WriteLine("ВВедите X1");
			//double X1 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("ВВедите X1");
			//double Y1 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("ВВедите X1");
			//double X2 = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("ВВедите X1");
			//double Y2 = Convert.ToDouble(Console.ReadLine());

			//double R = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
			//Console.WriteLine($"Результат: {R:#.##}");
			//Console.WriteLine(LL(X1, X2, Y1, Y2));
			#endregion

			#region task4

			//int a = 2;
			//int b = 3;
			//int c;
			//c=a; a=b; b=c;

			//a ^= b;
			//b ^= a;
			//a ^= b;


			//Console.WriteLine($"a={a}; b={b}");



			#endregion

			#region task5

			string wr = "Hi!";
			Console.SetCursorPosition((Console.WindowWidth-wr.Length) / 2, Console.WindowHeight / 2);
			Console.WriteLine("Hi!");

			#endregion

			Console.ReadLine();


		}
	}
}
