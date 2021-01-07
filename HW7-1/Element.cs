using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_1
{
	public class Element
	{

		public string Tag { get; set; }
		public string Str { get; set; }

		public bool check { get; set; }

		public Element()
		{

		}

		public Element(string tag,string newString)
		{
			this.Tag = tag;
			Str = newString;
			check = false;
		}
		public override string ToString()
		{
			return Str;
		}
	}
}
