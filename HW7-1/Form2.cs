using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_1
{
	public partial class Form2 : Form
	{
		Form1 form1;
		Element elem;
		public Form2(Form1 f, Element el)
		{
			InitializeComponent();
			this.form1 = f;
			elem = el;
			txtBoxCh.Name = el.Str;

		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			elem.Str = txtBoxCh.Text;
			elem.check = true;
			
			form1.ListRef();
		}
	}
}
