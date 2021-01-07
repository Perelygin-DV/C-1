using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW7_1
{
	public class TextWork
	{
		public Element[] e;
		//public Element[] Changed;

		public TextWork()
		{
			e = new Element[8]
		  {
			new Element("name1",""),
			new Element("name2",""),
			new Element("name3",""),
			new Element("name4",""),
			new Element("name5",""),
			new Element("data1",""),
			new Element("data2",""),
			new Element("data3","")
		  };



		}

		//public string this[int index] { get { return e[index].Str; } set { e[index].Str = value; } }
		
		public string Repl(string file)
		{
			//.Split(new char[] { '\n' });
				foreach (Element el in e)
				{
				
					Regex reg = new Regex("<" + el.Tag + ">");
					if (el.check) { file = reg.Replace(file , el.Str); }
					else { file = reg.Replace(file, ""); };
				
			}
			int maxL = 20;


			List<string> filemod = new List<string>();
				
				string[] m=file.Split(new char[] { '\n' });

			for (int i = 0; i < m.Length; i++)
			{
				filemod.Add(m[i]);

			}

			foreach (string item in filemod)
			{
				if (item.Length > maxL) maxL = item.Length;

			}

			for (int i = 0; i < 4; i++)
			{
				filemod[i] = filemod[i].PadLeft(maxL);
				//filemod[i] = filemod[i].PadRight(maxL);
			}


			string res = string.Empty;


			foreach (string item in filemod)
			{
				res += item + "\n";
			}

			return res;
		}

		






	}
}
