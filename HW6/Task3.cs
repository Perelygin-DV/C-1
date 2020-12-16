using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
	class Task3
	{
		int fivecourse = 0;
		int sixthcourse = 0;
		int between = 0; //between 18-20 which course
						 //sort by age
						 //sort by course ang gae

		List<Student> list = new List<Student>();

		int MyDelegate(Student st1, Student st2)
		{
			return (st1.age == st2.age) ? 0 : (st1.age > st2.age) ? 1 : (-1);

		}




		public void Read(string name)
		{
			StreamReader sr = new StreamReader(name);
			while (!sr.EndOfStream)
			{
				try
				{
					string[] s = sr.ReadLine().Split(';');
					list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
					if (Console.ReadKey().Key == ConsoleKey.Escape) return;
				}
			}
			sr.Close();
		}


		public Task3()
		{
			Read("fdfsa");
			Console.WriteLine($"Количество пятых:{fivecourse}, Количество шестых: {sixthcourse}");

			Between();


			list.Sort(new Comparison<Student>(MyDelegate));



		}

		void Course()
		{
			foreach(Student el in list)
			{
				if (el.course == 5) fivecourse++;
				if (el.course == 6) sixthcourse++;
			}


		}


		void Between()
		{
			int[] Number = new int[5];
			foreach(Student el in list)
			{
				if (el.age > 17 && el.age < 21) Number[el.course]++;
			}
			int i = 0;
			foreach(int el in Number)
			{
				Console.WriteLine($"Курс: {++i} количество: {el} ");
			}




		}



	}
}
