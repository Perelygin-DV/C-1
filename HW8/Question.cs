using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
	[Serializable]
	public class Question
	{
		public string text;
		public bool trueFalse;
		


		public Question (string text, bool trueFalse)
		{
			this.text = text;
			this.trueFalse = trueFalse;
		}

		public Question()
		{

		}





	}
}
