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

namespace HW8
{
	public partial class Form1 : Form
	{
		TrueFalse database;
		int QSNumber=0;
		int CorrectQ = 0;
		bool csv = false;
		
		public Form1()
		{
			InitializeComponent();
			database = new TrueFalse("base.txt");
			//database.Convert();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				//ofd.Filter = "CSV files(*.csv)| *.csv | XML files(*.xml) | *.xml";
				
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string ext = Path.GetExtension(ofd.FileName);
					database.FileName = ofd.FileName;
					//MessageBox.Show(ext);
					if (ext == ".csv" || ext == ".CSV")
					{
						database.Convert();
						this.csv = true;
					}
					else { database.Load(); this.csv = false; }
					nudNumber.Minimum = 1;
					nudNumber.Maximum = database.Count;
					nudNumber.Value = 1;
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				//database.FileName = sfd.FileName;
				database = new TrueFalse(sfd.FileName);
				database.Add("123", true);
				database.Save(database.FileName);
				nudNumber.Minimum = 1;
				nudNumber.Maximum = 1;
			}
		}


		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (database != null)
			{ if (csv == false) database.Save(database.FileName);
				else database.Save(database.FileName + ".xml");
			}
			else MessageBox.Show("База данных не создана");
		}


		private void nudNumber_ValueChanged(object sender, EventArgs e)
		{
			tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
			cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Сообщение");
				return;
			}
			database.Add((database.Count + 1).ToString(), true);
			nudNumber.Maximum = database.Count;
			nudNumber.Minimum = database.Count;

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			
			if (MessageBox.Show("Вы действительно хотите удалить вопрос?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK) { 
			if (nudNumber.Maximum == 1 || database == null) return;
			database.Remove((int)nudNumber.Value);
			nudNumber.Maximum--;
			if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
			}
						

		}

	

		private void btnSave_Click(object sender, EventArgs e)
		{
			database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
			database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
		}

		private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string about = $"Автор: Дмитрий \n Версия: 1.0.0 \n авторскийе права";
			MessageBox.Show(about, "О программе", MessageBoxButtons.OK);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			tboxQuestion.Text = database.GetQuestion();
			label1.Text = "0";
			QSNumber = 0;
			CorrectQ = 0;

		}


		private void btnTrue_Click(object sender, EventArgs e)
		{
			QSNumber++;
			if (QSNumber < 6)
			{
				if (database.Check(true)) { CorrectQ++; label1.Text = CorrectQ.ToString(); };
				tboxQuestion.Text = database.GetQuestion();
				
			}
			else
			{
				MessageBox.Show("Game Over");
				QSNumber = 0;
				CorrectQ = 0;
				database.CleanStack();

			}
		}

		private void btnFalse_Click(object sender, EventArgs e)
		{
			QSNumber++;
			if (QSNumber < 6)
			{
				if (database.Check(false)) { CorrectQ++; label1.Text = CorrectQ.ToString(); };
				tboxQuestion.Text = database.GetQuestion();
				
			}
			else
			{
				MessageBox.Show("Game Over");
				QSNumber = 0;
				CorrectQ = 0;
				database.CleanStack();

			}

		}

		private void openCSVToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "*.csv|*.CSV";
			if (ofd.ShowDialog() == DialogResult.OK)
				{

					//database = new TrueFalse();
					//database.Convert(ofd.FileName, database.FileName);
					//database.Load();
					nudNumber.Minimum = 1;
					nudNumber.Maximum = database.Count;
					nudNumber.Value = 1;
				}
				//database.Save();

			}
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
