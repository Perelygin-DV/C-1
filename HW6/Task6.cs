using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW6
{
	class Task6
	{
		public Task6()
		{
			List<string> result = new List<string>();
			string [] fs = Directory.GetFiles("C:\\HTML", ".",SearchOption.AllDirectories);
			foreach(var filename in fs)
			{
				Regex regex = new Regex(@"<img src=");
				string s = File.ReadAllText(filename,Encoding.Default);
				int start;
				int end;

				
				foreach(Match c in regex.Matches(s))
				{
					start = c.Index;
					//s.IndexOfAny(new char[] { })
					end=s.IndexOf('>', start);

					string els = s.Substring(start + 11, end - start - 12);
					if(els.Contains(".png")|| els.Contains(".jpg")|| els.Contains(".gif")) result.Add(els);




				}

			}

			//result.RemoveAll(".gif", ".png", ".jpg" );

			//for (int i = result.Count - 1; i == 0; i--)
			//{
			//	if (result[i].Contains(".png") ) result.Remove(result[i]);
			//}



			Console.WriteLine(result.Count);
			foreach(var el in result)
			{
				Console.WriteLine(el);
			}

		}



	}
}
