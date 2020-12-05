using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
	class Task4
	{
		Random rnd = new Random();
		Student[] school;

	


		public Task4()
		{
			Reader("Students.txt");
			Show(school);
			Console.WriteLine();
	

		}

		void Reader(string path)
		{
			StreamReader str = new StreamReader (path);
			int N = File.ReadAllLines(path).Length;
			
			string[] curstud;
			school = new Student[N];

			for (int i = 0; i < N; i++)
			{
				curstud = str.ReadLine().Split(new char[] { ';' });

				school[i] = new Student(
					curstud[0],
					curstud[1],
					Convert.ToInt32(curstud[2]),
					Convert.ToInt32(curstud[3]),
					Convert.ToInt32(curstud[4])
					);

			}
			str.Close();
			
		}

	public void Best()
	{
				int L = school.Length;
				Double Be = 0;
				//Double Wo = 5;
				for (int i = 0; i < L; i++)
				{
					if (school[i].Average > Be) Be = school[i].Average;

			    }
			Console.WriteLine("Список лучших учеников:");

			for (int i = 0; i < L; i++)
			{
				if (school[i].Average == Be) Console.WriteLine($"\t{school[i].Name} - {school[i].Family} - {school[i].Average}");
			}
		}

		public void Worst()
		{
			int L = school.Length;
			Double Wo = 5;
			//Double Wo = 5;
			for (int i = 0; i < L; i++)
			{
				if (school[i].Average < Wo) Wo = school[i].Average;

			}
			Console.WriteLine("Список худших учеников:");

			for (int i = 0; i < L; i++)
			{
				if (school[i].Average == Wo) Console.WriteLine($"\t{school[i].Name} - {school[i].Family} - {school[i].Average}");
			}
		}




		public void Show(Student[] std)
		{
			foreach (Student item in std)
			{
				Console.WriteLine($"{item.Name} {item.Family} {item.Math} {item.Rus} {item.Lit}");

			}
		}




	}
}
