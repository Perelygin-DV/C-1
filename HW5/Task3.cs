using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
	class Task3
	{
		public Task3()
		{
			
		}

		public bool Stand(string a, string b)
		{
			a = a.Trim();
			b = b.Trim();

			StringBuilder d = new StringBuilder(a);
		
			
			
			
			
			
			StringBuilder e = new StringBuilder();

			




			string bb = String.Empty;
			char[] cc = b.Reverse().ToArray();
			for (int i = 0; i < cc.Length; i++)
			{
				bb += cc[i];

			}

		
			bool s = String.Compare(a, bb)==0;
			

			return s;

		}

		public bool Mine(string a, string b)
		{
			a = a.ToLower().Trim();
			b = b.ToLower().Trim();
			char[] aa = a.ToCharArray();
			char[] bb = b.ToCharArray();

			if (aa.Length == bb.Length)
			{
				for (int i = 0; i < aa.Length; i++)
				{
					if (aa[i] != bb[bb.Length - i-1]) return false;

				}
				return true;
			}
			else return false;

		}



	}
}
