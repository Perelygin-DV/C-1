using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
	class Udvoitel
	{
		int current = 0;
		int finish;

		public int X2()
		{
			return current * 2;
		}

		public int MIN()
		{
			return current - 1;
		}

		public int PLUS()
		{
			return current + 1;
		}

		public int Current { get { return current; } }

		public int Finish { get { return finish; } }

		public Udvoitel()
		{
			Random rnd = new Random();
			finish = rnd.Next(10, 100);
			char r = new char();


			Console.WriteLine(Console.ReadKey().KeyChar);


			while (current < finish)
			{

				if (current == finish) { Console.WriteLine("Победа"); break; };
				r = Console.ReadKey().KeyChar;

				switch (r)
				{
					case ('+'): current=PLUS(); break;
					case ('-'): current=MIN(); break;
					case ('*'): current=X2(); break;
					case ('1'):current = 1;break;
					default: continue;
				}
				Console.WriteLine($"Счет: {Current}");
				if (current > finish) Console.WriteLine("проигрыш");
			}
			Console.WriteLine("finish ="+finish);
			Console.ReadKey();

		}
	}
}
