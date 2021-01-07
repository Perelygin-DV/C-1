
namespace HW7
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNumber = new System.Windows.Forms.Label();
			this.btnCommand1 = new System.Windows.Forms.Button();
			this.btnCommand2 = new System.Windows.Forms.Button();
			this.btnCommand3 = new System.Windows.Forms.Button();
			this.lbCounter = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUndo = new System.Windows.Forms.Button();
			this.lbGoal = new System.Windows.Forms.Label();
			this.boxChk = new System.Windows.Forms.TextBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.lblCheck = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(53, 147);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(13, 13);
			this.lblNumber.TabIndex = 0;
			this.lblNumber.Text = "0";
			// 
			// btnCommand1
			// 
			this.btnCommand1.Location = new System.Drawing.Point(189, 86);
			this.btnCommand1.Name = "btnCommand1";
			this.btnCommand1.Size = new System.Drawing.Size(75, 23);
			this.btnCommand1.TabIndex = 1;
			this.btnCommand1.Text = "+1";
			this.btnCommand1.UseVisualStyleBackColor = true;
			this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
			// 
			// btnCommand2
			// 
			this.btnCommand2.Location = new System.Drawing.Point(189, 137);
			this.btnCommand2.Name = "btnCommand2";
			this.btnCommand2.Size = new System.Drawing.Size(75, 23);
			this.btnCommand2.TabIndex = 2;
			this.btnCommand2.Text = "x2";
			this.btnCommand2.UseVisualStyleBackColor = true;
			this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
			// 
			// btnCommand3
			// 
			this.btnCommand3.Location = new System.Drawing.Point(189, 188);
			this.btnCommand3.Name = "btnCommand3";
			this.btnCommand3.Size = new System.Drawing.Size(75, 23);
			this.btnCommand3.TabIndex = 3;
			this.btnCommand3.Text = "reset";
			this.btnCommand3.UseVisualStyleBackColor = true;
			this.btnCommand3.Click += new System.EventHandler(this.btnCommand3_Click);
			// 
			// lbCounter
			// 
			this.lbCounter.AutoSize = true;
			this.lbCounter.Location = new System.Drawing.Point(12, 256);
			this.lbCounter.Name = "lbCounter";
			this.lbCounter.Size = new System.Drawing.Size(127, 13);
			this.lbCounter.TabIndex = 4;
			this.lbCounter.Text = "Количество комманд: 0";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// playToolStripMenuItem
			// 
			this.playToolStripMenuItem.Name = "playToolStripMenuItem";
			this.playToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.playToolStripMenuItem.Text = "Play";
			this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
			// 
			// btnUndo
			// 
			this.btnUndo.Location = new System.Drawing.Point(189, 246);
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.Size = new System.Drawing.Size(75, 23);
			this.btnUndo.TabIndex = 6;
			this.btnUndo.Text = "Undo";
			this.btnUndo.UseVisualStyleBackColor = true;
			this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
			// 
			// lbGoal
			// 
			this.lbGoal.AutoSize = true;
			this.lbGoal.Location = new System.Drawing.Point(30, 28);
			this.lbGoal.Name = "lbGoal";
			this.lbGoal.Size = new System.Drawing.Size(0, 13);
			this.lbGoal.TabIndex = 7;
			// 
			// boxChk
			// 
			this.boxChk.Location = new System.Drawing.Point(341, 249);
			this.boxChk.Name = "boxChk";
			this.boxChk.Size = new System.Drawing.Size(100, 20);
			this.boxChk.TabIndex = 8;
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(470, 249);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 9;
			this.btnCheck.Text = "Check!";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// lblCheck
			// 
			this.lblCheck.AutoSize = true;
			this.lblCheck.Location = new System.Drawing.Point(341, 209);
			this.lblCheck.Name = "lblCheck";
			this.lblCheck.Size = new System.Drawing.Size(0, 13);
			this.lblCheck.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblCheck);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.boxChk);
			this.Controls.Add(this.lbGoal);
			this.Controls.Add(this.btnUndo);
			this.Controls.Add(this.lbCounter);
			this.Controls.Add(this.btnCommand3);
			this.Controls.Add(this.btnCommand2);
			this.Controls.Add(this.btnCommand1);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Button btnCommand1;
		private System.Windows.Forms.Button btnCommand2;
		private System.Windows.Forms.Button btnCommand3;
		private System.Windows.Forms.Label lbCounter;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
		private System.Windows.Forms.Button btnUndo;
		private System.Windows.Forms.Label lbGoal;
		private System.Windows.Forms.TextBox boxChk;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label lblCheck;
	}
}

