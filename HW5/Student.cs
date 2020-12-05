using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW5
{
	class Student
	{
		string family;
		string name;
		int math;
		int rus;
		int lit;


		public string Name => name;
		public string Family => family;

		public int Math => math;
		public int Rus => rus;
		public int Lit => lit;


		public double Average => System.Math.Round(Convert.ToDouble(math + rus + lit) / 3,2);

		public Student (string family, string name, int math, int rus, int lit)
		{
			this.family = family;
			this.name = name;
			this.math = math;
			this.rus = rus;
			this.lit = lit;
		}

	}
}
