using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			string s = File.ReadAllText("shablon.txt");
			lbRes.Text = s;

			
			//txw = new TextWork();
			ListRef();
			//lbRes.Text=txw.Repl(s);
		}

		//List<Element> col;
		public TextWork txw=new TextWork();
	
		private void btnRef_Click(object sender, EventArgs e)
		{
			string s = File.ReadAllText("shablon.txt");
						
		     lbRes.Text = txw.Repl(s);

		}


		string Formed(string [] s)
		{
			int maxL = 20;
			


			foreach (string item in s)
			{
				if (item.Length > maxL) maxL = item.Length;

			}

			for(int i = 0; i < 4; i++)
			{
				s[i] = s[i].PadLeft(maxL);
			}


			string res =string.Empty;
			foreach (var item in s)
			{
				res += item + "\n";

			}

			return res;

		}

		public void ListRef()
		{
			this.listBox1.Items.Clear();
			foreach (var item in this.txw.e)
			{
				this.listBox1.Items.Add(item);
			}
			string m = string.Empty;

			for (int i = 0; i < this.txw.e.Length; i++)
			{
				switch (i)
				{
					case 0: m = "Директору"; break;
					case 1: m = "ФИО Директора"; break;
					case 2: m = "Должность сотрудника"; break;
					case 3: m = "ФИО сотрудника"; break;
					case 4: m = "ФИО сотрудника"; break;
					case 5: m = "Отпуск с"; break;
					case 6: m = "Отпуск по"; break;
					case 7: m = "Дата подписи"; break;
				};
				if(txw.e[i].Str == "")
				{
					txw.e[i].Str = m;
				}

				//this.listBox1.Items.Add(txw.e[i].Str);
			}
			//listBox1.Items.Add(new Element { Tag = "name25", Str = "fsadfdsaf" });


		}

		Form2 fr2;

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			fr2 = new Form2(this, listBox1.Items[listBox1.SelectedIndex] as Element);
			fr2.ShowDialog();

		}
	}
}
