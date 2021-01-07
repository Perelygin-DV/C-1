using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
	public partial class Form1 : Form
	{
		static Random rnd = new Random();
		int goal = rnd.Next(10, 100);
		
		Stack<string> save = new Stack<string>();
		int count = 1;


		public Form1()
		{
			InitializeComponent();
			btnCommand1.Text = "+1";
			btnCommand2.Text = "x2";
			btnCommand3.Text = "reset";
			this.Text = "Удвоитель";
			lbGoal.Text = $"Цель: {goal}";
			lblNumber.Text = "0";
			
		}

		private void btnCommand1_Click(object sender, EventArgs e)
		{
			lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
			save.Push(lblNumber.Text);
			lbCounter.Text="Число комманд: " + count++;
			Check();

		}

		private void btnCommand2_Click(object sender, EventArgs e)
		{
			lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
			save.Push(lblNumber.Text);
			lbCounter.Text = "Число комманд: " + count++;
			count++;
			Check();
		}

		private void btnCommand3_Click(object sender, EventArgs e)
		{
			lblNumber.Text = "1";
			save.Clear();
			save.Push("1");
			count++;

		}
		

		private void playToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Вам нужно получить "+goal+" очков") ;
		}

		private void Check()
		{
			if(int.Parse(lblNumber.Text)>goal)
			{
				MessageBox.Show("перебор");
				lblNumber.Text = "0";

			}
			else if(int.Parse(lblNumber.Text) == goal)
			{
				MessageBox.Show("Победа!");
			}
		}

		private void btnUndo_Click(object sender, EventArgs e)
		{
			save.Pop();
			lblNumber.Text = save.Peek();


		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			int num = int.Parse(boxChk.Text);
			if (num > goal) { lblCheck.Text = "Меньше!"; }
			else if ( num == goal)
			{ MessageBox.Show("Все верно!"); }
			else { lblCheck.Text = "Больше!"; }
		}
	}
}
