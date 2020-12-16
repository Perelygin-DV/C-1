using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW6
{
	class Task4
	{

		Regex reg = new Regex(@"\d{3}-\d{2}-\d{2}|\d{3}-\d{3}|\d{2}-\d{2}-\d{2}");


		public Task4()
		{
			Read("telephone.txt");
			Console.ReadKey();
		}


		void Read(string filename)
		{
			StreamReader str = new StreamReader(filename);
			string find = str.ReadToEnd();
			
			
			foreach(var el in reg.Matches(find))
			{
				Console.WriteLine(el);
			}
		}
	}
}
